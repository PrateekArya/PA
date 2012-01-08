'   Created By  Hiranmoy Basak
'               email id: hiranmoy.iitkgp@gmail.com


'References :
'   Name                                                            Type
'  ------                                                          ------
'   Microsoft ActiveX Data Objects 2.5 Library                      COM
'   Microsoft CDO for Windows 2000 Library                          COM
'   Microsoft Speech Object Library                                 COM


'Imports SpeechLib
'Imports System.Windows.Forms
Imports System.IO
Imports ADODB
Imports CDO


Public Class Form1

    Public time(1), hr(10), mn(10), row_sel, form_ref, pro, core, history_tab, flag_tab, cut_copy, flag_pro, hd_com As Integer
    Public path(10), cur_dir, music, media_pl, addresses(0), past_add, rect_add(10), closed_add(10), copy_folder, cmd_command, pw_guid(), fd_size_nm As String
    Public wpage() As WebBrowser
    Public wb_temp As New WebBrowser
    Public lx As New DataGridView

    'Dim voice As New SpVoice

    'System boot

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'public
        Me.MaximizeBox = False

        form_ref = 0
        hd_com = 0

        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath + "\suppoting_files") = False Then
            My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\suppoting_files")
        End If

        Try
            My.Computer.FileSystem.DeleteFile(Application.StartupPath + "\suppoting_files\end_main.hb")
        Catch
        End Try

        'Clock

        time(0) = 0


        'Alarm

        am_pm_al.Items.Add("AM")
        am_pm_al.Items.Add("PM")
        am_pm_al.SelectedIndex = 0
        Alarm_list.Items.Add("Alarms set : 0")
        pro = 0
        media_pl = "C:\Program Files (x86)\The KMPlayer\KMPlayer.exe"
        Call load_music()


        'Schedule

        Call load_pick(0)


        'Shortcuts

        Call load_path()


        'explorer

        cur_dir = ""
        cut_copy = 0
        copy_folder = ""
        Call load_partions()


        'sync

        am_pm_sync.Items.Add("AM")
        am_pm_sync.Items.Add("PM")
        am_pm_sync.SelectedIndex = 0
        Call load_sync()


        'browser

        addresses(0) = "http://www.google.co.in/"
        past_add = ""
        history_tab = -1
        Call load_history()
        Call add_tab()
        wb_temp = wpage(0)
        AddHandler wb_temp.DocumentCompleted, AddressOf DocumentCompleted
        'AddHandler wb_temp.NewWindow, AddressOf popup


        'task manager

        flag_pro = -1
        Call load_process()


        'core

        core = core_val.Value


        'power plan

        Call load_power()


        'voice

        'voice.Volume = 100
        'voice.Speak("Welcome Hiranmoy")

    End Sub

    Private Sub maxb_en_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles maxb_en.CheckedChanged
        Me.MaximizeBox = maxb_en.Checked
    End Sub

    Private Sub end_comp_Clicks(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles end_lt_comp.Click, end_all_comp.Click

        Dim i, j As Integer
        Dim process1() As Process = Process.GetProcesses()
        Dim pro_temp As Process
        Dim button_temp As Button = sender

        For i = 1 To 1 Step 1
            If i = hd_com Or button_temp.Text = "end_all_comp" Then

                Select Case i
                    Case 1
                        Timer_fd_size.Enabled = False

                        For Each pro_temp In process1

                            On Error Resume Next

                            If pro_temp.ProcessName = "fd-size" Then
                                pro_temp.Kill()
                            End If

                        Next

                        For j = 0 To core Step 1
                            On Error Resume Next

                            My.Computer.FileSystem.DeleteFile(Application.StartupPath + "\suppoting_files\fd_out" + CStr(j) + ".hb")
                        Next
                End Select
            End If
        Next

        core_label.Text = "Number of CPU cores to be used for computation :"
        core_val.Enabled = True

    End Sub

    'System shut down

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Dim i, j As Integer

        Me.Hide()

        FileOpen(1, Application.StartupPath + "\suppoting_files\end_main.hb", OpenMode.Output)
        FileClose(1)

        If addresses.Length <> 1 Then

            Try
                FileOpen(1, Application.StartupPath + "\suppoting_files\history.hb", OpenMode.Output)

                For i = 0 To addresses.Length - 1 Step 1
                    Print(1, addresses(i) + Chr(13))
                Next

                FileClose(1)
            Catch
            End Try


            Try
                FileOpen(1, Application.StartupPath + "\suppoting_files\history_sorted.hb", OpenMode.Output)

                For i = 0 To lx.RowCount - 2 Step 1
                    For j = 0 To 2 Step 1
                        Print(1, lx.Item(j, i).Value + Chr(13))
                    Next
                Next

                FileClose(1)
            Catch
            End Try

        End If

    End Sub

    'Clock

    Private Sub Timer_keep_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_keep.Tick

        'public
        Dim t1 As String = "Current Time - "
        Dim temp As Integer = System.DateTime.Now.TimeOfDay.Hours

        Select Case temp

            Case 0 To 9 : t1 = t1 + "0" + temp.ToString + ":"

            Case 10 To 12 : t1 += temp.ToString + ":"

            Case 13 To 21 : t1 += "0" + CStr(temp - 12) + ":"

            Case 22 To 23 : t1 += CStr(temp - 12) + ":"

        End Select

        temp = System.DateTime.Now.TimeOfDay.Minutes

        If temp < 10 Then
            t1 += "0" + temp.ToString + ":"
        Else : t1 += temp.ToString + ":"
        End If

        temp = System.DateTime.Now.TimeOfDay.Seconds

        If temp < 10 Then
            t1 += "0" + temp.ToString + " "
        Else : t1 += temp.ToString + " "
        End If

        If System.DateTime.Now.TimeOfDay.Hours >= 12 Then
            t1 = t1 + "pm"
        Else : t1 = t1 + "am"
        End If


        If real_time.Text <> t1 Then
            time(0) += 1
        End If

        real_time.Text = t1

        If Me.WindowState = FormWindowState.Minimized Then
            form_ref = 1
        ElseIf form_ref = 1 Then
            Me.Refresh()
            form_ref = 0
        End If

        If time(0) > 1 Then
            Timer_keep.Interval = 1000
            Timer_refresh.Enabled = True
        End If

        If calendar.TodayDate.Day <> System.DateTime.Now.Day Then
            calendar.TodayDate = System.DateTime.Now
        End If

        If top_most.Checked = True Then
            Me.TopMost = True
        Else : Me.TopMost = False
        End If

    End Sub

    'Alarm

    Private Sub start_al_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles start_al.Click

        'public
        If Alarm_list.Items.Count = hr.Length Then
            MsgBox("Already " + CStr(hr.Length - 1) + " alarms are set")
            Return
        End If

        hr(Alarm_list.Items.Count - 1) = hour_al.Value Mod 12 + 12 * am_pm_al.SelectedIndex
        mn(Alarm_list.Items.Count - 1) = min_al.Value

        Call sort_al()

        Timer_al.Enabled = True
        Timer_play.Enabled = False

    End Sub

    Private Sub delete_al_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delete_al.Click
        Call del_al(Alarm_list.SelectedIndex)
    End Sub

    Private Sub test_al_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles test_al.Click
        Call play()
    End Sub

    Private Sub stop_al_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stop_al.Click

        Dim i As Integer
        Dim media_p(5) As String

        Timer_play.Enabled = False
        'My.Computer.Audio.Stop()

        media_p(0) = "System.Diagnostics.Process (KMPlayer)"
        media_p(1) = "System.Diagnostics.Process (PotPlayerMini)"
        media_p(2) = "System.Diagnostics.Process (PotPlayerMini64)"
        media_p(3) = "System.Diagnostics.Process (PotPlayer)"
        media_p(4) = "System.Diagnostics.Process (splayer)"

        Try
            For i = 0 To 4 Step 1
                If Process.GetProcessById(pro).ToString = media_p(i) Then
                    Process.GetProcessById(pro).Kill()
                    Exit For
                End If
            Next
        Catch
        End Try

    End Sub

    Private Sub browse_al_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles browse_al.Click

        File_browse.InitialDirectory = My.Computer.FileSystem.GetParentPath(music)
        Timer_keep.Enabled = False
        File_browse.ShowDialog()
        Timer_keep.Enabled = True

        If music = File_browse.FileName Or File_browse.FileName = "OpenFileDialog1" Then
            Exit Sub
        End If

        music = File_browse.FileName

        FileOpen(1, Application.StartupPath + "\suppoting_files\music.hb", OpenMode.Output)
        Print(1, music)
        FileClose(1)

        music_nm_al.Text = My.Computer.FileSystem.GetName(music)
        Call play()

    End Sub

    Private Sub browse_media_al_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles browse_media_al.Click

        File_browse.InitialDirectory = My.Computer.FileSystem.GetParentPath(media_pl)
        Timer_keep.Enabled = False
        File_browse.ShowDialog()
        Timer_keep.Enabled = True

        If media_pl = File_browse.FileName Or File_browse.FileName = "OpenFileDialog1" Then
            Exit Sub
        End If

        media_pl = File_browse.FileName

        FileOpen(1, Application.StartupPath + "\suppoting_files\media_pl.hb", OpenMode.Output)
        Print(1, media_pl)
        FileClose(1)
        Call play()

    End Sub


    Private Sub ts_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t1.CheckedChanged, t2.CheckedChanged, t3.CheckedChanged

        If t1.Checked = True Then
            Timer_play.Interval = 300000
        End If

        If t2.Checked = True Then
            Timer_play.Interval = 600000
        End If

        If t3.Checked = True Then
            Timer_play.Interval = 1200000
        End If

    End Sub

    Private Sub min_al_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles min_al.ValueChanged

        If min_al.Value >= 60 Then
            min_al.Value -= 60
            hour_al.Value += 1
        End If

    End Sub

    Private Sub hour_al_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hour_al.ValueChanged

        If hour_al.Value = 12 Then

            am_pm_al.SelectedIndex = 1 - am_pm_al.SelectedIndex

            If am_pm_al.SelectedIndex = 0 Then
                hour_al.Value = 0
            End If
        End If

        If hour_al.Value > 12 Then
            hour_al.Value -= 12
        End If

    End Sub


    Private Sub Timer_play_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_play.Tick
        Call play()
    End Sub

    Private Sub Timer_al_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_al.Tick

        Dim i As Integer

        For i = 0 To Alarm_list.Items.Count - 1 Step 1

            If My.Computer.Clock.LocalTime.Hour = hr(i) Then

                If My.Computer.Clock.LocalTime.Minute = mn(i) Then

                    del_al(i + 1)
                    Timer_play.Enabled = True
                    Call play()
                    Return
                End If
            End If
        Next

    End Sub

    Private Sub Timer_refresh_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_refresh.Tick

        If Timer_al.Enabled = False Then

            min_al.Value = System.DateTime.Now.TimeOfDay.Minutes

            If System.DateTime.Now.TimeOfDay.Hours > 12 Then
                hour_al.Value = System.DateTime.Now.TimeOfDay.Hours - 12
            Else : hour_al.Value = System.DateTime.Now.TimeOfDay.Hours
            End If

            am_pm_al.SelectedIndex = Int(My.Computer.Clock.LocalTime.Hour / 12)

        End If

    End Sub

    Private Sub Timer_al_refresh_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_al_refresh.Tick

        Timer_al_refresh.Interval = 300000

        Dim s As String = real_time.Text

        If Alarm_list.Items.Count > 1 Then
            Exit Sub
        End If

        hour_al.Value = CInt(s.Substring(15, 2))
        min_al.Value = CInt(s.Substring(18, 2))

        If s(24) = "p" Then
            am_pm_al.SelectedIndex = 1
        Else : am_pm_al.SelectedIndex = 0
        End If

    End Sub


    Private Sub play()

        'My.Computer.Audio.Play(Application.StartupPath + "\suppoting_files\music1.wav", AudioPlayMode.Background)

        Dim s, media_p(5) As String
        Dim i As Integer
        s = music

        media_p(0) = "System.Diagnostics.Process (KMPlayer)"
        media_p(1) = "System.Diagnostics.Process (PotPlayerMini)"
        media_p(2) = "System.Diagnostics.Process (PotPlayerMini64)"
        media_p(3) = "System.Diagnostics.Process (PotPlayer)"
        media_p(4) = "System.Diagnostics.Process (splayer)"

        s = """" + s + """"
        
        Try
            For i = 0 To 4 Step 1
                If Process.GetProcessById(pro).ToString = media_p(i) Then
                    Process.GetProcessById(pro).Kill()
                    Exit For
                End If
            Next
        Catch
        End Try

        Try
            pro = Shell(media_pl + " " + s + " \close", AppWinStyle.MinimizedFocus)

        Catch
            MsgBox("Bad Media Player")
        End Try

    End Sub

    Private Sub sort_al()

        'public
        Dim i, j, n, temp As Integer

        n = Alarm_list.Items.Count

        Alarm_list.Items.Clear()
        Alarm_list.Items.Add("Alarms set : " + CStr(n))

        For i = 0 To n - 1 Step 1
            For j = i + 1 To n - 1 Step 1

                If hr(i) > hr(j) Then

                    temp = hr(i)
                    hr(i) = hr(j)
                    hr(j) = temp
                    temp = mn(i)
                    mn(i) = mn(j)
                    mn(j) = temp

                ElseIf hr(i) = hr(j) And mn(i) > mn(j) Then

                    temp = mn(i)
                    mn(i) = mn(j)
                    mn(j) = temp

                End If
            Next

            If hr(i) < 12 Then
                Alarm_list.Items.Add(hr(i).ToString + " : " + mn(i).ToString + " am")
            ElseIf hr(i) > 12 Then
                Alarm_list.Items.Add(CStr(hr(i) - 12) + " : " + mn(i).ToString + " pm")
            Else : Alarm_list.Items.Add("12 : " + mn(i).ToString + " pm")
            End If
        Next

    End Sub

    Private Sub del_al(ByVal n As Integer)

        'public
        Dim i As Integer

        If n < 1 Or n > Alarm_list.Items.Count - 1 Then
            Return
        End If

        For i = n - 1 To Alarm_list.Items.Count - 2
            hr(i) = hr(i + 1)
            mn(i) = mn(i + 1)
        Next

        Alarm_list.Items.RemoveAt(n)
        Alarm_list.Items(0) = "Alarms set : " + CStr(Alarm_list.Items.Count - 1)

        If Alarm_list.Items.Count < 2 Then
            Timer_al.Enabled = False
        End If

        Alarm_list.SelectedIndex = -1

    End Sub

    Private Sub load_music()

        Try
            FileOpen(1, Application.StartupPath + "\suppoting_files\music.hb", OpenMode.Input)
            music = LineInput(1)
            FileClose(1)
            music_nm_al.Text = My.Computer.FileSystem.GetName(music)
        Catch
            music = Application.StartupPath + "\suppoting_files\music1.wav"
        End Try

        Try
            FileOpen(1, Application.StartupPath + "\suppoting_files\media_pl.hb", OpenMode.Input)
            media_pl = LineInput(1)
            FileClose(1)
        Catch
        End Try

    End Sub

    'Schedule   

    Private Sub save_sche_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save_sche.Click

        'public
        If task_list.Rows.Count < 2 Then
            Return
        End If

        task_list.Item(0, row_sel).Value = date_pick.Value.ToString.Substring(0, date_pick.Value.ToString.Length - 2) + "00"

        task_list.Sort(task_list.Columns(0), System.ComponentModel.ListSortDirection.Ascending)

        Call save_pick()

    End Sub

    Private Sub delete_pick_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delete_pick.Click

        'public
        Try
            task_list.Rows.RemoveAt(row_sel)
        Catch
            Return
        End Try

        If row_sel = 1 Then
            row_sel -= 1
        End If

        Call save_pick()

    End Sub

    Private Sub refresh_pick_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles refresh_pick.Click

        task_list.Rows.Clear()
        Call load_pick(0)

    End Sub

    Private Sub restore_task_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles restore_task.Click
        task_list.Rows.Clear()
        Call load_pick(1)
    End Sub


    Private Sub task_list_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles task_list.CellClick

        'public
        row_sel = e.RowIndex

        Try
            date_pick.Value = task_list.Item(0, row_sel).Value
            'voice.Speak(task_list.Item(1, row_sel).Value.ToString)
        Catch
        End Try

    End Sub


    Private Sub save_pick()

        Dim i As Integer

        Try
            My.Computer.FileSystem.CopyFile(Application.StartupPath + "\suppoting_files\schedule.hb", Application.StartupPath + "\suppoting_files\schedule_backup.hb", True)
        Catch
        End Try

        FileOpen(1, Application.StartupPath + "\suppoting_files\schedule.hb", OpenMode.Output)

        For i = 0 To task_list.Rows.Count - 2 Step 1

            Try
                Print(1, task_list.Item(0, i).Value.ToString + Chr(13))
            Catch
                Print(1, " " + Chr(13))
            End Try

            Try
                Print(1, task_list.Item(1, i).Value.ToString + Chr(13))
            Catch
                Print(1, " " + Chr(13))
            End Try

            Try
                Print(1, task_list.Item(2, i).Value.ToString + Chr(13))
            Catch
                Print(1, " " + Chr(13))
            End Try

            Try
                Print(1, task_list.Item(3, i).Value.ToString + Chr(13))
            Catch
                Print(1, " " + Chr(13))
            End Try

        Next

        FileClose(1)

    End Sub

    Private Sub load_pick(ByVal n As Integer)

        Dim i, j As Integer

        i = 0

        If n = 0 Then
            Try
                FileOpen(1, Application.StartupPath + "\suppoting_files\schedule.hb", OpenMode.Input)
            Catch
                Return
            End Try
        Else
            Try
                FileOpen(1, Application.StartupPath + "\suppoting_files\schedule_backup.hb", OpenMode.Input)
            Catch
                Return
            End Try
        End If
        

        While (1)

            Try
                task_list.Rows.Add()
                For j = 0 To 3
                    task_list.Item(j, i).Value = LineInput(1)
                Next
                i += 1
            Catch
                FileClose(1)
                Exit While
            End Try

        End While

        task_list.Rows.RemoveAt(task_list.Rows.Count - 2)

    End Sub

    'shortcut

    Private Sub add_f_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add_f.Click

        Dim str1 As String = InputBox("Name of the shortcut")

        If str1 = "" Or str1 = " " Then
            Exit Sub
        End If

        Timer_keep.Enabled = False
        folder_browse.ShowDialog()
        Timer_keep.Enabled = True

        If folder_browse.SelectedPath = "" Then
            Exit Sub
        End If

        loc_f.Text = folder_browse.SelectedPath
        shortcuts.Items.Add(str1)

        path(shortcuts.Items.Count - 1) = loc_f.Text

        Call save_path()

    End Sub

    Private Sub edit_f_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edit_f.Click

        If shortcuts.SelectedIndex < 0 Then
            Exit Sub
        End If

        folder_browse.SelectedPath = path(shortcuts.SelectedIndex)
        Timer_keep.Enabled = False
        folder_browse.ShowDialog()
        Timer_keep.Enabled = True

        If folder_browse.SelectedPath = path(shortcuts.SelectedIndex) Then
            Exit Sub
        End If

        loc_f.Text = folder_browse.SelectedPath
        path(shortcuts.SelectedIndex) = loc_f.Text

        Call save_path()

    End Sub

    Private Sub open_folders(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles open_f.Click, shortcuts.DoubleClick

        Me.WindowState = FormWindowState.Minimized
        Shell("explorer.exe " + loc_f.Text, AppWinStyle.NormalFocus)

    End Sub

    Private Sub delete_f_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delete_f.Click

        Dim i As Integer

        If shortcuts.SelectedIndex < 0 Then
            Exit Sub
        End If

        For i = shortcuts.SelectedIndex To shortcuts.Items.Count - 2 Step 1
            path(i) = path(i + 1)
        Next

        shortcuts.Items.RemoveAt(shortcuts.SelectedIndex)

        Call save_path()

    End Sub

    Private Sub up_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles up.Click

        Dim i As Integer = shortcuts.SelectedIndex
        Dim s As String

        If shortcuts.SelectedIndex < 1 Then
            Exit Sub
        End If

        s = path(i)
        path(i) = path(i - 1)
        path(i - 1) = s
        s = shortcuts.Items(i)
        shortcuts.Items(i) = shortcuts.Items(i - 1)
        shortcuts.Items(i - 1) = s

        shortcuts.SelectedIndex = i - 1

        Call save_path()

    End Sub

    Private Sub down_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles down.Click

        Dim i As Integer = shortcuts.SelectedIndex
        Dim s As String

        If shortcuts.SelectedIndex < 0 Or shortcuts.SelectedIndex = shortcuts.Items.Count - 1 Then
            Exit Sub
        End If

        s = path(i)
        path(i) = path(i + 1)
        path(i + 1) = s
        s = shortcuts.Items(i)
        shortcuts.Items(i) = shortcuts.Items(i + 1)
        shortcuts.Items(i + 1) = s

        shortcuts.SelectedIndex = i + 1

        Call save_path()

    End Sub

    Private Sub shortcuts_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles shortcuts.MouseClick

        Try
            Call load_path_tr(loc_f.Text, treDirectory.Nodes(0))
        Catch
        End Try

    End Sub


    Private Sub shortcuts_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles shortcuts.SelectedIndexChanged

        shortcuts.Enabled = False

        Try
            loc_f.Text = path(shortcuts.SelectedIndex)
        Catch
            Try
                loc_f.Text = path(0)
            Catch
            End Try
        End Try

        Try
            If My.Computer.FileSystem.DirectoryExists(loc_f.Text) = True Then
                Call load_path_tr(loc_f.Text, treDirectory.Nodes(0))
            End If
        Catch
        End Try

        shortcuts.Enabled = True

    End Sub


    Private Sub save_path()

        Dim i As Integer

        FileOpen(1, Application.StartupPath + "\suppoting_files\shortcuts.hb", OpenMode.Output)

        For i = 0 To shortcuts.Items.Count - 1 Step 1

            Print(1, shortcuts.Items(i).ToString + Chr(13))
            Print(1, path(i) + Chr(13))
        Next

        FileClose(1)

    End Sub

    Private Sub load_path()

        Dim i As Integer = 0

        Try
            FileOpen(1, Application.StartupPath + "\suppoting_files\shortcuts.hb", OpenMode.Input)
        Catch
            Return
        End Try

        While (1)

            Try
                shortcuts.Items.Add(LineInput(1))
                path(i) = LineInput(1)
                i += 1
            Catch
                FileClose(1)
                Exit While
            End Try
        End While

        If i <> 0 Then
            shortcuts.SelectedIndex = 0
            loc_f.Text = path(0)
        End If

    End Sub

    'explorer

    Private Sub ref_ex_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ref_ex.Click
        Call refresh_treDirectory()
    End Sub


    Private Sub treDirectory_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles treDirectory.AfterSelect
        Call node_load(e.Node)
    End Sub

    Private Sub treDirectory_AfterExpand(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles treDirectory.AfterExpand
        Call node_load(e.Node)
    End Sub

    Private Sub treDirectory_NodeMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles treDirectory.NodeMouseDoubleClick
        'treDirectory.SelectedNode = treDirectory.GetNodeAt(e.X, e.Y)
        Call open_folder()
    End Sub

    Private Sub treDirectory_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles treDirectory.MouseDown

        Dim ts(6) As ToolStripItem
        Dim x As New ContextMenuStrip

        If e.Button = Windows.Forms.MouseButtons.Right Then

            treDirectory.SelectedNode = treDirectory.GetNodeAt(e.X, e.Y)

            ts(0) = x.Items.Add("Open", Nothing, AddressOf OpenfolderToolStripMenuItem_Click)
            ts(0).Tag = sender

            ts(1) = x.Items.Add("Cut", Nothing, AddressOf CutfolderToolStripMenuItem_Click)
            ts(1).Tag = sender

            ts(2) = x.Items.Add("Copy", Nothing, AddressOf CopyfolderToolStripMenuItem_Click)
            ts(2).Tag = sender

            ts(3) = x.Items.Add("Paste", Nothing, AddressOf PastefolderToolStripMenuItem_Click)
            ts(3).Tag = sender

            ts(4) = x.Items.Add("New Folder", Nothing, AddressOf NewFolderToolStripMenuItem_Click)
            ts(4).Tag = sender

            ts(5) = x.Items.Add("Size", Nothing, AddressOf SizefolderToolStripMenuItem_Click)
            ts(5).Tag = sender

            x.Show(sender, e.Location)

        End If

    End Sub


    Private Sub OpenfolderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call open_folder()
    End Sub

    Private Sub CutfolderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cut_copy = 1
        copy_folder = cur_dir
    End Sub

    Private Sub CopyfolderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cut_copy = 2
        copy_folder = cur_dir
    End Sub

    Private Sub PastefolderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If cut_copy = 1 Then

            Try
                My.Computer.FileSystem.MoveDirectory(copy_folder, cur_dir + "\" + My.Computer.FileSystem.GetDirectoryInfo(copy_folder).Name)
            Catch
                Try
                    My.Computer.FileSystem.MoveFile(copy_folder, cur_dir + "\" + My.Computer.FileSystem.GetName(copy_folder))
                Catch
                    MsgBox("System cannot complete the operation")
                End Try
            End Try

        ElseIf cut_copy = 2 Then

            Try
                My.Computer.FileSystem.CopyDirectory(copy_folder, cur_dir + "\" + My.Computer.FileSystem.GetDirectoryInfo(copy_folder).Name)
            Catch
                Try
                    My.Computer.FileSystem.CopyFile(copy_folder, cur_dir + "\" + My.Computer.FileSystem.GetName(copy_folder))
                Catch
                    MsgBox("System cannot complete the operation")
                End Try
            End Try
        End If

    End Sub

    Private Sub NewFolderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim i As Integer = 1

        While (1)
            If My.Computer.FileSystem.DirectoryExists(cur_dir + "\New Folder") = False Then
                My.Computer.FileSystem.CreateDirectory(cur_dir + "\New Folder")
                Exit Sub
            Else : i += 1
                If My.Computer.FileSystem.DirectoryExists(cur_dir + "\New Folder(" + CStr(i) + ")") = False Then
                    My.Computer.FileSystem.CreateDirectory(cur_dir + "\New Folder(" + CStr(i) + ")")
                    Exit Sub
                End If
            End If
        End While

    End Sub

    Private Sub SizefolderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim size As Double
        Dim s As String

        fd_size_nm = cur_dir

        If My.Computer.FileSystem.FileExists(fd_size_nm) = True Then

            size = My.Computer.FileSystem.GetFileInfo(fd_size_nm).Length
            s = My.Computer.FileSystem.GetName(fd_size_nm) + "  :  "
            s = convert_B(size, s)
            Timer_keep.Enabled = False
            MsgBox(s)
            Timer_keep.Enabled = True
        Else
            Try
                FileOpen(1, Application.StartupPath + "\suppoting_files\core.hb", OpenMode.Output)
                Print(1, CStr(core))
                FileClose(1)

                s = Application.StartupPath + "\suppoting_files\fd-size.exe"
                s = """" + s + """"
                Shell(s, AppWinStyle.Hide)
                hd_com = 1
                core_label.Text = "Computing is going on," + Chr(13) + "cannot change the number of allocated cores"
                core_val.Enabled = False
            Catch
                Exit Sub
            End Try

            Call DirectorySize(fd_size_nm)
        End If

    End Sub


    Private Sub Timer_fd_size_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_fd_size.Tick

        Dim i As Integer
        Dim size As Long = 0
        Dim s As String

        For i = 0 To core Step 1
            If My.Computer.FileSystem.FileExists(Application.StartupPath + "\suppoting_files\fd_out" + CStr(i) + ".hb") = False Then
                Exit Sub
            End If
        Next

        Timer_fd_size.Enabled = False
        hd_com = 0

        For i = 0 To core Step 1
            FileOpen(1, Application.StartupPath + "\suppoting_files\fd_out" + CStr(i) + ".hb", OpenMode.Input)
            size += CLng(LineInput(1))
            FileClose(1)
            My.Computer.FileSystem.DeleteFile(Application.StartupPath + "\suppoting_files\fd_out" + CStr(i) + ".hb")
        Next

        s = My.Computer.FileSystem.GetName(fd_size_nm) + "  :  "
        If s = "  :  " Then
            s = fd_size_nm.Substring(0, fd_size_nm.IndexOf(":") + 1) + " "
        End If

        s = convert_B(size, s)
        Timer_keep.Enabled = False
        MsgBox(s)
        Timer_keep.Enabled = True

        core_label.Text = "Number of CPU cores to be used for computation :"
        core_val.Enabled = True

    End Sub


    Private Sub load_partions()

        Dim partitions As DriveInfo() = System.IO.DriveInfo.GetDrives
        Dim i As Integer

        treDirectory.Nodes.Add("My Computer")

        For i = 0 To partitions.Length - 1 Step 1
            treDirectory.Nodes(0).Nodes.Add(partitions(i).Name.Substring(0, 2))
        Next

    End Sub

    Private Sub PopulateTreeView(ByVal directoryValue As String, ByVal parentNode As TreeNode, ByVal index As Integer)

        Dim currentDirectory, currentfile As String

        directoryValue = get_dir(directoryValue, parentNode)

        Try

            Dim directoryArray As String() = Directory.GetDirectories(directoryValue)
            Dim fileArray As String() = Directory.GetFiles(directoryValue)

            If directoryArray.Length <> 0 Then

                For Each currentDirectory In directoryArray
                    Dim myNode1 As TreeNode = New TreeNode(My.Computer.FileSystem.GetDirectoryInfo(currentDirectory).Name)

                    parentNode.Nodes.Add(myNode1)

                    If index = 1 Then
                        PopulateTreeView(myNode1.Text, myNode1, 0)
                    End If
                Next
            End If

            If fileArray.Length <> 0 Then

                For Each currentfile In fileArray
                    Dim myNode2 As TreeNode = New TreeNode(My.Computer.FileSystem.GetName(currentfile))
                    parentNode.Nodes.Add(myNode2)
                Next
            End If
        Catch
        End Try

    End Sub

    Private Sub node_load(ByVal n As TreeNode)

        Dim i As Integer

        If cur_dir <> get_dir(n.Text, n) Then

            cur_dir = get_dir(n.Text, n)

            Try
                For i = 0 To n.Parent.GetNodeCount(True) - 1 Step 1
                    If cur_dir <> n.Parent.Nodes(i).Text Then
                        n.Parent.Nodes(i).Collapse(True)
                    End If
                Next
            Catch
            End Try

        End If

        n.Expand()

        If n.GetNodeCount(False) = 0 Then
            PopulateTreeView(n.Text, n, 1)
        Else
            For i = 0 To n.GetNodeCount(False) - 1 Step 1
                Try
                    If n.Nodes(i).GetNodeCount(False) = 0 Then
                        PopulateTreeView(n.Nodes(i).Text, n.Nodes(i), 0)
                    End If
                Catch
                End Try
            Next
        End If

    End Sub

    Function get_dir(ByVal directoryValue As String, ByVal parentNode As TreeNode)

        Dim dir As String
        Dim parents As TreeNode

        dir = ""

        Try
            parents = parentNode.Parent

            While parents.Level > 0
                dir = parents.Text + "\" + dir
                parents = parents.Parent
            End While

        Catch
        End Try

        directoryValue = dir + directoryValue
        directoryValue = directoryValue.Insert(2, "\")

        Try
            directoryValue = directoryValue.Remove(3, 1)
        Catch
        End Try

        Return (directoryValue)

    End Function

    Private Sub load_path_tr(ByVal folder_path As String, ByVal n As TreeNode)

        Dim i, index As Integer
        Dim s As String

        index = folder_path.IndexOf("\")

        If index <> -1 Then
            s = folder_path.Substring(0, index)
            folder_path = folder_path.Substring(index + 1, folder_path.Length - index - 1)
        Else : s = folder_path
        End If

        n.Expand()

        For i = 0 To n.Nodes.Count - 1 Step 1

            If n.Nodes(i).Text = s Then
                Exit For
            End If
        Next

        If index = -1 Then
            n.Nodes(i).Expand()
        Else : Call load_path_tr(folder_path, n.Nodes(i))
        End If

    End Sub

    Private Sub open_folder()
        Me.WindowState = FormWindowState.Minimized
        Shell("explorer.exe " + cur_dir, AppWinStyle.NormalFocus)
    End Sub

    Private Sub DirectorySize(ByVal sPath As String)

        Dim Size As Long = 0
        Dim i, flag1 As Integer
        Dim diDir As New DirectoryInfo(sPath)
        Dim s As String

        i = 0
        flag1 = 0

        Try
            Dim fil As FileInfo

            For Each fil In diDir.GetFiles()
                Size += fil.Length
            Next fil

            Dim diSubDir As DirectoryInfo

            For i = 1 To core Step 1
                FileOpen(i, Application.StartupPath + "\suppoting_files\fd_size" + CStr(i) + ".hb", OpenMode.Output)
            Next

            For Each diSubDir In diDir.GetDirectories()
                Print(i Mod core + 1, diSubDir.FullName + Chr(13))
                i += 1
                flag1 = 1
            Next diSubDir

        Catch
        End Try

        For i = 1 To core Step 1
            FileClose(i)
        Next

        If flag1 = 1 Then
            FileOpen(1, Application.StartupPath + "\suppoting_files\fd_out0.hb", OpenMode.Output)
            Print(1, Size)
            FileClose(1)

            Timer_fd_size.Enabled = True
        Else
            s = My.Computer.FileSystem.GetName(fd_size_nm) + "  :  "
            s = convert_B(Size, s)
            Timer_keep.Enabled = False
            MsgBox(s)
            Timer_keep.Enabled = True
        End If

    End Sub

    Private Sub refresh_treDirectory()

        Dim i, j, k, flag1 As Integer
        Dim partitions As DriveInfo() = System.IO.DriveInfo.GetDrives
        Dim tr_node(1) As TreeNode
        Dim old_path As String = cur_dir

        j = 0
        For i = 0 To partitions.Length - 1 Step 1

            flag1 = 0

            If i >= treDirectory.Nodes(0).Nodes.Count Then
                treDirectory.Nodes(0).Nodes.Add(partitions(i).Name.Substring(0, 2))
                node_load(treDirectory.Nodes(0).Nodes(i))
                Continue For
            End If

            j = i
            If partitions(i).Name.Substring(0, 2) <> treDirectory.Nodes(0).Nodes(j).Text Then

                While (j < treDirectory.Nodes(0).Nodes.Count)

                    If partitions(i).Name.Substring(0, 2) = treDirectory.Nodes(0).Nodes(j).Text Then

                        For k = i To j - 1 Step 1
                            treDirectory.Nodes(0).Nodes.RemoveAt(k)
                            flag1 = 1
                            Exit While
                        Next
                    End If
                    j += 1
                End While

                If flag1 <> 1 Then
                    treDirectory.Nodes(0).Nodes.Insert(i, partitions(i).Name.Substring(0, 2))
                    node_load(treDirectory.Nodes(0).Nodes(i))
                End If

            End If
            j += 1
        Next

        While (i < treDirectory.Nodes(0).Nodes.Count)
            treDirectory.Nodes(0).Nodes.RemoveAt(i)
        End While

        For i = 0 To treDirectory.Nodes(0).Nodes.Count - 1 Step 1
            refresh_folder(treDirectory.Nodes(0).Nodes(i).Text.Substring(0, 2), treDirectory.Nodes(0).Nodes(i))
        Next

        Try
            Call load_path_tr(old_path, treDirectory.Nodes(0))
        Catch
        End Try

    End Sub

    Function convert_B(ByVal num As Double, ByVal s As String)

        Dim i As Integer = 0

        While (num > 1024)
            num /= 1024
            i += 1
        End While

        Try
            s = s + CStr(num).Substring(0, CStr(num).IndexOf(".") + 3)
        Catch
            s = s + CStr(num)
        End Try

        Select Case i
            Case 0 : s = s + " B"
            Case 1 : s = s + " KB"
            Case 2 : s = s + " MB"
            Case 3 : s = s + " GB"
            Case 4 : s = s + " TB"
        End Select

        Return (s)

    End Function

    Private Sub refresh_folder(ByVal directoryValue As String, ByVal parentNode As TreeNode)

        Dim currentDirectory, currentfile As String
        Dim i, j, k, flag1 As Integer

        directoryValue = get_dir(directoryValue, parentNode)

        Dim directoryArray As String() = Directory.GetDirectories(directoryValue)
        Dim fileArray As String() = Directory.GetFiles(directoryValue)


        Try

            If directoryArray.Length <> 0 Then

                For Each currentDirectory In directoryArray
                    Dim myNode1 As TreeNode = New TreeNode(My.Computer.FileSystem.GetDirectoryInfo(currentDirectory).Name)

                    parentNode.Nodes.Add(myNode1)

                    If index = 1 Then
                        PopulateTreeView(myNode1.Text, myNode1, 0)
                    End If
                Next
            End If

            If fileArray.Length <> 0 Then

                For Each currentfile In fileArray
                    Dim myNode2 As TreeNode = New TreeNode(My.Computer.FileSystem.GetName(currentfile))
                    parentNode.Nodes.Add(myNode2)
                Next
            End If
        Catch
        End Try

        For i = 0 To directoryArray.Length - 1 Step 1

            flag1 = 0

            If i >= parentNode.Nodes.Count Then
                parentNode.Nodes.Add(directoryArray(i).Substring(0, 2))
                node_load(parentNode.Nodes(i))
                Continue For
            End If

            j = i
            If directoryArray(i).Substring(0, 2) <> parentNode.Nodes(j).Text Then

                While (j < treDirectory.Nodes(0).Nodes.Count)

                    If partitions(i).Name.Substring(0, 2) = parentNode.Nodes(j).Text Then

                        For k = i To j - 1 Step 1
                            parentNode.Nodes.RemoveAt(k)
                            flag1 = 1
                            Exit While
                        Next
                    End If
                    j += 1
                End While

                If flag1 <> 1 Then
                    parentNode.Nodes.Insert(i, partitions(i).Name.Substring(0, 2))
                    node_load(parentNode.Nodes(i))
                End If

            End If
            j += 1
        Next

        While (i < treDirectory.Nodes(0).Nodes.Count)
            treDirectory.Nodes(0).Nodes.RemoveAt(i)
        End While


    End Sub

    'browser

    Private Sub closeb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call close_tab(Webpage.SelectedTab)
    End Sub

    Private Sub delb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim i, ro() As Integer

        Try
            i = lx.SelectedCells(0).RowIndex
        Catch
            Exit Sub
        End Try

        ReDim ro(lx.SelectedCells.Count - 1)

        For i = 0 To lx.SelectedCells.Count - 1 Step 1
            ro(i) = lx.SelectedCells(i).RowIndex
        Next

        Array.Sort(ro)

        For i = lx.SelectedCells.Count - 1 To 0 Step -1

            Try
                While (ro(i) = ro(i - 1))
                    i -= 1
                End While
            Catch
            End Try

            If ro(i) < lx.RowCount - 1 Then
                lx.Rows.RemoveAt(ro(i))
            End If
        Next

    End Sub


    Public Sub lx_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

        If flag_tab = 1 Then
            Exit Sub
        End If

        flag_tab = 1

        Dim tpage = New TabPage("webpage " + CStr(Webpage.TabPages.Count + 1))
        Dim wp As New WebBrowser()

        Webpage.TabPages.Add(tpage)

        ReDim Preserve wpage(Webpage.TabPages.Count)
        wpage(Webpage.TabPages.Count - 1) = wp
        wpage(Webpage.TabPages.Count - 1).Parent = tpage
        wpage(Webpage.TabPages.Count - 1).Dock = DockStyle.Fill
        wpage(Webpage.TabPages.Count - 1).Navigate(lx.Item(1, e.RowIndex).Value)

        Webpage.SelectedTab = tpage

        flag_tab = 0

    End Sub


    Private Sub history_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles history.KeyPress

        Dim key_pressed As Integer

        key_pressed = Microsoft.VisualBasic.Asc(e.KeyChar)

        If key_pressed = 13 Or key_pressed = 10 Then

            If key_pressed = 10 Then
                history.Text = "http://www." + history.Text + ".com"
            End If

            wpage(Webpage.SelectedIndex).Navigate(history.Text)

            history.DroppedDown = False

            Exit Sub
        End If

        Timer_browser.Enabled = True

    End Sub

    Private Sub history_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles history.SelectedIndexChanged

        Try
            wpage(Webpage.SelectedIndex).Navigate(history.SelectedItem.ToString)
        Catch
            Exit Sub
        End Try

    End Sub

    Private Sub Webpage_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Webpage.MouseDown

        Dim ts(4) As ToolStripItem
        Dim x As New ContextMenuStrip
        Dim i As Integer

        If e.Button = Windows.Forms.MouseButtons.Right Then

            For i = 0 To sender.TabPages.Count - 1
                If sender.GetTabRect(i).Contains(e.X, e.Y) Then
                    sender.SelectedIndex = i
                    Exit For
                End If
            Next

            ts(0) = x.Items.Add("Close Tab", Nothing, AddressOf CloseCurrentTabToolStripMenuItems_Click)
            ts(0).Tag = sender

            ts(1) = x.Items.Add("New Tab", Nothing, AddressOf AddTabToolStripMenuItems_Click)
            ts(1).Tag = sender

            ts(2) = x.Items.Add("Refresh", Nothing, AddressOf RefreshToolStripMenuItems_Click)
            ts(2).Tag = sender

            ts(3) = x.Items.Add("Close Other Tabs", Nothing, AddressOf CloseotherTabsToolStripMenuItems_Click)
            ts(3).Tag = sender

            x.Show(sender, e.Location)
        End If

    End Sub

    Private Sub Webpage_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Webpage.SelectedIndexChanged

        If Webpage.SelectedIndex <> history_tab Then

            Try
                Menu_browser.Enabled = True
                Webpage.SelectedTab.Text = wpage(Webpage.SelectedIndex).DocumentTitle
                history.Text = wpage(Webpage.SelectedIndex).Url.AbsoluteUri.ToString
                wb_temp = wpage(Webpage.SelectedIndex)

                AddHandler wb_temp.DocumentCompleted, AddressOf DocumentCompleted
                'AddHandler wb_temp.NewWindow, AddressOf popup
            Catch
            End Try
        Else
            Menu_browser.Enabled = False
        End If

    End Sub


    Private Sub DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs)

        Webpage.SelectedTab.Text = wpage(Webpage.SelectedIndex).DocumentTitle
        history.Text = wpage(Webpage.SelectedIndex).Url.AbsoluteUri.ToString

        'If wpage(Webpage.SelectedIndex).Url.AbsoluteUri.ToString <> home_pg Then
        add_history()
        'End If

    End Sub


    Private Sub Timer_browser_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_browser.Tick

        Timer_browser.Enabled = False

        Dim s As String = history.Text
        Dim i As Integer

        Me.Cursor.Current = Cursors.Arrow

        Try
            s = history.Text
        Catch
            history.Items.Clear()
            Exit Sub
        End Try

        If past_add = history.Text Then
            Exit Sub
        End If

        past_add = history.Text

        history.Items.Clear()

        history.SelectionStart = history.Text.Length

        For i = 0 To addresses.Length - 1 Step 1
            If addresses(i).Contains(s) Then
                history.Items.Add(addresses(i))
            End If
        Next

        history.DroppedDown = True

    End Sub

    Private Sub Timer_br_refresh_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_br_refresh.Tick

        Try
            If wpage(Webpage.SelectedIndex).ReadyState.ToString <> "Complete" Then
                Exit Sub
            End If
        Catch
        End Try

        If Webpage.SelectedTab.Text <> wpage(Webpage.SelectedIndex).DocumentTitle Then
            Webpage.SelectedTab.Text = wpage(Webpage.SelectedIndex).DocumentTitle
            history.Text = wpage(Webpage.SelectedIndex).Url.AbsoluteUri.ToString
        End If

    End Sub


    Private Sub GoBackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoBackToolStripMenuItem.Click
        wpage(Webpage.SelectedIndex).GoBack()
    End Sub

    Private Sub GoForwardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoForwardToolStripMenuItem.Click
        wpage(Webpage.SelectedIndex).GoForward()
    End Sub

    Private Sub StopToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StopToolStripMenuItem.Click
        wpage(Webpage.SelectedIndex).Stop()
    End Sub

    Private Sub RefreshToolStripMenuItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        wpage(Webpage.SelectedIndex).Refresh()
    End Sub

    Private Sub SearchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchToolStripMenuItem.Click
        wpage(Webpage.SelectedIndex).GoSearch()
    End Sub

    Private Sub GoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoToolStripMenuItem.Click
        wpage(Webpage.SelectedIndex).Navigate(history.Text)
        history.DroppedDown = False
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAsToolStripMenuItem.Click

        Dim Url, FilePath As String

        file_save.InitialDirectory = Application.StartupPath + "\suppoting_files\"
        file_save.FileName = wpage(Webpage.SelectedIndex).DocumentTitle
        Timer_keep.Enabled = False
        file_save.ShowDialog()
        Timer_keep.Enabled = True

        'wpage(Webpage.SelectedIndex).ShowSaveAsDialog()

        'wbsitepage = wpage(Webpage.SelectedIndex).DocumentText
        'My.Computer.FileSystem.WriteAllText (file_save.FileName, wbsitepage.ToString, False)

        'Dim myWebClient As New System.Net.WebClient
        'myWebClient.DownloadFile(wpage(Webpage.SelectedIndex).Url.AbsoluteUri.ToString, file_save.FileName)

        Url = wpage(Webpage.SelectedIndex).Url.AbsoluteUri.ToString
        FilePath = file_save.FileName

        Dim iMessage As CDO.Message = New CDO.Message
        iMessage.CreateMHTMLBody(Url, _
        CDO.CdoMHTMLFlags.cdoSuppressNone, "", "")
        Dim adodbstream As ADODB.Stream = New ADODB.Stream
        adodbstream.Type = ADODB.StreamTypeEnum.adTypeText
        adodbstream.Charset = "US-ASCII"
        adodbstream.Open()
        iMessage.DataSource.SaveToObject(adodbstream, "_Stream")
        adodbstream.SaveToFile(FilePath, ADODB.SaveOptionsEnum.adSaveCreateOverWrite)

    End Sub

    Private Sub ClearHistoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearHistoryToolStripMenuItem.Click

        Dim i As Integer

        Try
            My.Computer.FileSystem.DeleteFile(Application.StartupPath + "\suppoting_files\history.hb")
        Catch
        End Try

        Try
            My.Computer.FileSystem.DeleteFile(Application.StartupPath + "\suppoting_files\history_sorted.hb")
        Catch
        End Try

        ReDim addresses(0)
        addresses(0) = "http://www.google.co.in/"

        RecentlyClosedTabToolStripMenuItem.DropDownItems.Clear()
        RecentPagesToolStripMenuItem.DropDownItems.Clear()

        For i = 0 To rect_add.Length - 1 Step 1
            rect_add(i) = ""
            closed_add(i) = ""
        Next

        lx.Rows.Clear()

    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click

        File_browse.InitialDirectory = Application.StartupPath + "\suppoting_files\"
        Timer_keep.Enabled = False
        File_browse.ShowDialog()
        Timer_keep.Enabled = True
        wpage(Webpage.SelectedIndex).Navigate(File_browse.FileName)
        Webpage.SelectedTab.Text = wpage(Webpage.SelectedIndex).DocumentTitle
        history.Text = File_browse.FileName

    End Sub

    Private Sub AddTabToolStripMenuItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddTabToolStripMenuItem.Click
        Call add_tab()
    End Sub

    Private Sub CloseotherTabsToolStripMenuItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseOtherTabsToolStripMenuItem.Click

        Dim index As Integer = Webpage.SelectedIndex

        While (Webpage.TabPages.Count > index + 1)
            Call close_tab(Webpage.TabPages(index + 1))
        End While

        While (Webpage.TabPages.Count > 1)
            Call close_tab(Webpage.TabPages(0))
        End While

        Webpage.TabPages(0).Text = wpage(0).DocumentTitle
        history.Text = wpage(0).Url.AbsoluteUri.ToString

    End Sub

    Private Sub CloseCurrentTabToolStripMenuItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseCurrentTabToolStripMenuItem.Click, CloseCurrentTabToolStripMenuItem2.Click
        Call close_tab(Webpage.SelectedTab)
    End Sub

    Private Sub PrintPreviewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewToolStripMenuItem.Click
        wpage(Webpage.SelectedIndex).ShowPrintPreviewDialog()
    End Sub

    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        wpage(Webpage.SelectedIndex).ShowPrintDialog()
    End Sub

    Private Sub ShowHistoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowHistoryToolStripMenuItem.Click

        Dim tpage = New TabPage("History")
        Dim delb, closeb, gob As New Button
        Dim wp = New WebBrowser()

        delb.Text = "Remove"
        delb.Height = 30
        delb.Width = 100
        delb.Top = Me.Height - 180
        delb.Left = 50

        closeb.Text = "Close History"
        closeb.Height = 30
        closeb.Width = 100
        closeb.Top = Me.Height - 180
        closeb.Left = Me.Width - 200

        AddHandler closeb.Click, AddressOf closeb_Click
        AddHandler delb.Click, AddressOf delb_Click
        AddHandler lx.CellDoubleClick, AddressOf lx_CellDoubleClick

        Webpage.TabPages.Add(tpage)
        Webpage.TabPages(Webpage.TabPages.Count - 1).Controls.Add(delb)
        Webpage.TabPages(Webpage.TabPages.Count - 1).Controls.Add(closeb)
        Webpage.TabPages(Webpage.TabPages.Count - 1).Controls.Add(lx)

        ReDim Preserve wpage(Webpage.TabPages.Count)
        wpage(Webpage.TabPages.Count - 1) = wp

        history_tab = Webpage.TabPages.Count - 1
        Webpage.SelectedIndex = history_tab

    End Sub

    Private Sub recent_Item_click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim i As Integer

        Dim innerItem, outeritem1, outeritem2 As New ToolStripMenuItem

        innerItem = sender
        outeritem1 = innerItem.OwnerItem
        outeritem2 = outeritem1.OwnerItem

        i = outeritem2.DropDownItems.IndexOf(outeritem1)

        If outeritem2.DropDownItems.IndexOf(outeritem1) = 2 Then
            wpage(Webpage.SelectedIndex).Navigate(rect_add(outeritem1.DropDownItems.IndexOf(innerItem)))
        Else
            wpage(Webpage.SelectedIndex).Navigate(closed_add(outeritem1.DropDownItems.IndexOf(innerItem)))
        End If

    End Sub


    Private Sub add_tab()

        Dim tpage = New TabPage("webpage " + CStr(Webpage.TabPages.Count + 1))
        Dim wp As New WebBrowser()

        Webpage.TabPages.Add(tpage)

        ReDim Preserve wpage(Webpage.TabPages.Count)
        wpage(Webpage.TabPages.Count - 1) = wp
        wpage(Webpage.TabPages.Count - 1).Parent = tpage
        wpage(Webpage.TabPages.Count - 1).Dock = DockStyle.Fill
        wpage(Webpage.TabPages.Count - 1).GoHome()

        Webpage.SelectedIndex = Webpage.TabPages.Count - 1

    End Sub

    Private Sub close_tab(ByVal tab_index As TabPage)

        Dim i, temp, flag1 As Integer
        Dim innerItem As New ToolStripMenuItem("")
        temp = Webpage.TabPages.IndexOf(tab_index)
        flag1 = 0

        If Webpage.TabPages.Count = 1 Then
            Exit Sub
        End If

        If temp <> history_tab Then

            For Each Str As String In closed_add
                If Str.Contains(wpage(Webpage.TabPages.IndexOf(tab_index)).Url.AbsoluteUri.ToString) Then
                    flag1 = 1
                    Exit For
                End If
            Next

            If flag1 = 0 Then

                For i = 9 To 1 Step -1
                    closed_add(i) = closed_add(i - 1)
                Next

                closed_add(0) = wpage(Webpage.TabPages.IndexOf(tab_index)).Url.AbsoluteUri.ToString

                RecentlyClosedTabToolStripMenuItem.DropDownItems.Add(innerItem)
                AddHandler innerItem.Click, AddressOf recent_Item_click

                If RecentlyClosedTabToolStripMenuItem.DropDownItems.Count = 11 Then
                    RecentlyClosedTabToolStripMenuItem.DropDownItems.RemoveAt(9)
                End If

                For i = RecentlyClosedTabToolStripMenuItem.DropDownItems.Count - 1 To 1 Step -1
                    RecentlyClosedTabToolStripMenuItem.DropDownItems(i).Text = RecentlyClosedTabToolStripMenuItem.DropDownItems(i - 1).Text
                Next

                RecentlyClosedTabToolStripMenuItem.DropDownItems(0).Text = wpage(Webpage.TabPages.IndexOf(tab_index)).DocumentTitle
            End If
        End If

        Select Case temp
            Case history_tab : history_tab = -1
            Case Is < history_tab : history_tab -= 1
        End Select

        Webpage.TabPages.Remove(tab_index)

        For i = temp To Webpage.TabPages.Count Step 1
            wpage(i) = wpage(i + 1)
        Next

        Try
            If temp = Webpage.TabCount Then
                Webpage.SelectedIndex = temp - 1
            Else : Webpage.SelectedIndex = temp
            End If
        Catch
        End Try

    End Sub

    Private Sub add_history()

        Dim i, flag1 As Integer
        Dim innerItem As New ToolStripMenuItem("")
        flag1 = 0

        For Each Str As String In rect_add
            If Str.Contains(wpage(Webpage.SelectedIndex).Url.AbsoluteUri.ToString) Then
                flag1 = 1
                Exit For
            End If
        Next

        If flag1 = 0 Then

            For i = 9 To 1 Step -1
                rect_add(i) = rect_add(i - 1)
            Next

            rect_add(0) = wpage(Webpage.SelectedIndex).Url.AbsoluteUri.ToString

            RecentPagesToolStripMenuItem.DropDownItems.Add(innerItem)
            AddHandler innerItem.Click, AddressOf recent_Item_click

            If RecentPagesToolStripMenuItem.DropDownItems.Count = 11 Then
                RecentPagesToolStripMenuItem.DropDownItems.RemoveAt(9)
            End If

            For i = RecentPagesToolStripMenuItem.DropDownItems.Count - 1 To 1 Step -1
                RecentPagesToolStripMenuItem.DropDownItems(i).Text = RecentPagesToolStripMenuItem.DropDownItems(i - 1).Text
            Next

            RecentPagesToolStripMenuItem.DropDownItems(0).Text = wpage(Webpage.SelectedIndex).DocumentTitle
        End If


        flag1 = 0

        For i = 0 To lx.RowCount - 2 Step 1
            If lx.Item(0, i).Value = wpage(Webpage.SelectedIndex).DocumentTitle Then
                flag1 = 1
                Exit For
            End If
        Next

        If flag1 = 0 Then

            lx.Rows.Add()
            'lx.Item(0, lx.RowCount - 2).Value = ""
            lx.Item(0, lx.RowCount - 2).Value = wpage(Webpage.SelectedIndex).DocumentTitle
            lx.Item(1, lx.RowCount - 2).Value = wpage(Webpage.SelectedIndex).Url.AbsoluteUri.ToString
            lx.Item(2, lx.RowCount - 2).Value = System.DateTime.Now.ToString
        Else
            lx.Item(1, i).Value = wpage(Webpage.SelectedIndex).Url.AbsoluteUri.ToString
            lx.Item(2, i).Value = System.DateTime.Now.ToString
        End If

        lx.Sort(lx.Columns(2), System.ComponentModel.ListSortDirection.Descending)


        For Each Str As String In addresses
            If Str.Contains(wpage(Webpage.SelectedIndex).Url.AbsoluteUri.ToString) Then
                Exit Sub
            End If
        Next

        ReDim Preserve addresses(addresses.Length)
        addresses(addresses.Length - 1) = wpage(Webpage.SelectedIndex).Url.AbsoluteUri.ToString

        Array.Sort(addresses)

    End Sub

    Private Sub load_history()

        Dim i, j As Integer
        Dim s As String

        lx.Width = 1300
        lx.Height = 500
        lx.Left = 20
        lx.Top = 20
        lx.Columns.Add("c0", "Title")
        lx.Columns(0).Width = 300
        lx.Columns.Add("c1", "URL")
        lx.Columns(1).Width = 750
        lx.Columns.Add("c2", "Time")
        lx.Columns(2).Width = 200

        For i = 0 To rect_add.Length - 1 Step 1
            rect_add(i) = ""
            closed_add(i) = ""
        Next

        i = 0

        Try
            FileOpen(1, Application.StartupPath + "\suppoting_files\history.hb", OpenMode.Input)

            While (1)
                Try
                    s = LineInput(1)
                    ReDim Preserve addresses(addresses.Length)
                    addresses(i) = s
                    i += 1
                Catch
                    Exit While
                End Try
            End While

            FileClose(1)
            ReDim Preserve addresses(addresses.Length - 2)
        Catch
            Try
                FileClose(1)
            Catch
            End Try
        End Try


        i = 0

        Try
            FileOpen(1, Application.StartupPath + "\suppoting_files\history_sorted.hb", OpenMode.Input)
        Catch
            Return
        End Try

        While (1)
            Try
                lx.Rows.Add()
                For j = 0 To 2
                    lx.Item(j, i).Value = LineInput(1)
                Next
                i += 1
            Catch
                FileClose(1)
                Exit While
            End Try
        End While

        lx.Rows.RemoveAt(lx.Rows.Count - 2)

    End Sub

    'task manager

    Private Sub end_process_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles end_process.Click

        Timer_process.Enabled = True

        Try
            Process.GetProcessById(CInt(task_manager.Item(4, task_manager.SelectedCells.Item(0).RowIndex).Value)).Kill()
            flag_pro = CInt(task_manager.Item(4, task_manager.SelectedCells.Item(0).RowIndex).Value)
            Timer_process.Interval = 100
        Catch
        End Try

    End Sub

    Private Sub close_process_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_process.Click

        Timer_process.Enabled = True

        Try
            Process.GetProcessById(CInt(task_manager.Item(4, task_manager.SelectedCells.Item(0).RowIndex).Value)).CloseMainWindow()
            flag_pro = CInt(task_manager.Item(4, task_manager.SelectedCells.Item(0).RowIndex).Value)
            Timer_process.Interval = 100
        Catch
        End Try

    End Sub


    Private Sub refr_task_mn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles refr_task_mn.CheckedChanged
        Timer_process.Enabled = refr_task_mn.Checked
    End Sub


    Private Sub Timer_process_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_process.Tick

        Timer_process.Enabled = False

        Dim index1, index2 As Integer

        Try
            Dim pro_temp As Process = Process.GetProcessById(flag_pro)
        Catch
            flag_pro = -1
        End Try

        If flag_pro < 0 Then
            Timer_process.Interval = 1000
        End If

        Try
            If task_manager.SelectedCells(0).Value <> "" Then
                index1 = task_manager.SelectedCells(0).RowIndex
                index2 = task_manager.SelectedCells(0).ColumnIndex
            Else
                index1 = 0
                index2 = 0
            End If
            Call load_process()
            task_manager.Item(index2, index1).Selected = True
        Catch
        End Try

        Timer_process.Enabled = refr_task_mn.Checked

    End Sub


    Private Sub load_process()

        Dim count, i, j, k As Integer
        Dim process1() As Process = Process.GetProcesses()
        Dim pro_temp As Process
        Dim date_temp As String
        Dim row_temp(5) As DataGridViewCell
        Dim str As String

        count = 0

        task_manager.Rows.Clear()
        task_manager.Rows.Add()

        For Each pro_temp In process1

            On Error Resume Next

            task_manager.Item(0, count).Value = pro_temp.ProcessName
            task_manager.Item(1, count).Value = Math.Round(pro_temp.PrivateMemorySize64 / 1048576)
            task_manager.Item(2, count).Value = pro_temp.Responding
            task_manager.Item(3, count).Value = pro_temp.StartTime.ToString.Trim
            task_manager.Item(4, count).Value = pro_temp.Id

            If task_manager.Item(3, count).Value <> "" Or all_pro.Checked = True Then
                task_manager.Rows.Add()
                count += 1
            End If
        Next

        task_manager.Rows.RemoveAt(count)

        'task_manager.Sort(task_manager.Columns(3), System.ComponentModel.ListSortDirection.Descending)

        For i = 0 To count - 1 Step 1
            For j = i + 1 To count - 1 Step 1
                If CDate(task_manager.Item(3, i).Value) < CDate(task_manager.Item(3, j).Value) Then
                    For k = 0 To 4 Step 1
                        str = task_manager.Item(k, i).Value.ToString
                        task_manager.Item(k, i).Value = task_manager.Item(k, j).Value.ToString
                        task_manager.Item(k, j).Value = str
                    Next
                End If
            Next
        Next

        If all_pro.Checked = True Then
            pro_count.Text = "All Processes : " + CStr(count)
        Else : pro_count.Text = "Important Processes : " + CStr(count)
        End If

    End Sub

    'core

    Private Sub core_val_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles core_val.ValueChanged

        If core_val.Value = 0 Then
            core_val.Value = 1
        End If

        core = core_val.Value

    End Sub

    'sync

    Private Sub Add_sync_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add_sync.Click

        Timer_keep.Enabled = False
        folder_browse.ShowDialog()
        Timer_keep.Enabled = True
        sync_list.Items.Add(folder_browse.SelectedPath)

        If folder_browse.SelectedPath = "" Then
            Exit Sub
        End If

        Timer_keep.Enabled = False
        folder_browse.ShowDialog()
        Timer_keep.Enabled = True

        If folder_browse.SelectedPath = "" Then
            Exit Sub
        End If

        sync_list.Items(sync_list.Items.Count - 1).SubItems.Add(folder_browse.SelectedPath)
        sync_list.Items(sync_list.Items.Count - 1).SubItems.Add("")

        sync_list.Height = 28 + 20 * sync_list.Items.Count

        Call save_sync()

    End Sub

    Private Sub remove_sync_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles remove_sync.Click

        sync_list.Items.RemoveAt(sync_list.SelectedItems.Item(0).Index)
        Call save_sync()
        sync_list.Height = 28 + 20 * sync_list.Items.Count

    End Sub

    Private Sub set_sync_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles set_sync.Click

        Dim t1 As String = "Current schedule - "
        Dim temp As Integer = hr_sync.Value

        If temp < 10 Then
            t1 = t1 + "0" + temp.ToString + ":"
        Else : t1 += temp.ToString + ":"
        End If

        temp = min_sync.Value

        If temp < 10 Then
            t1 += "0" + temp.ToString + " " + am_pm_sync.SelectedItem.ToString
        Else : t1 += temp.ToString + " " + am_pm_sync.SelectedItem.ToString
        End If

        label_sync.Text = t1

        FileOpen(1, Application.StartupPath + "\suppoting_files\sync_sche.hb", OpenMode.Output)

        Print(1, CStr(hr_sync.Value) + Chr(13))
        Print(1, CStr(min_sync.Value) + Chr(13))
        Print(1, CStr(am_pm_sync.SelectedIndex) + Chr(13))
        Print(1, t1 + Chr(13))

        FileClose(1)

        Timer_sync.Enabled = True

    End Sub

    Private Sub stop_sync_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stop_sync.Click

        Try
            My.Computer.FileSystem.DeleteFile(Application.StartupPath + "\suppoting_files\sync_sche.hb")

            hr_sync.Value = 0
            min_sync.Value = 0
            am_pm_sync.SelectedIndex = 0
            label_sync.Text = "Current schedule - "

            Timer_sync.Enabled = False

        Catch
        End Try

    End Sub


    Private Sub min_sync_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles min_sync.ValueChanged

        If min_sync.Value >= 60 Then
            min_sync.Value -= 60
            hr_sync.Value += 1
        End If

    End Sub

    Private Sub hr_sync_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hr_sync.ValueChanged

        If hr_sync.Value = 12 Then

            am_pm_sync.SelectedIndex = 1 - am_pm_sync.SelectedIndex

            If am_pm_sync.SelectedIndex = 0 Then
                hr_sync.Value = 0
            End If
        End If

        If hr_sync.Value > 12 Then
            hr_sync.Value -= 12
        End If

    End Sub


    Private Sub Timer_sync_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_sync.Tick

        If My.Computer.Clock.LocalTime.Hour = hr_sync.Value Mod 12 + 12 * am_pm_sync.SelectedIndex Then

            If My.Computer.Clock.LocalTime.Minute = min_sync.Value Then

                Timer_sync.Enabled = False
                'MsgBox("start")
            End If
        End If

    End Sub


    Private Sub save_sync()

        Dim i As Integer

        FileOpen(1, Application.StartupPath + "\suppoting_files\sync.hb", OpenMode.Output)

        For i = 0 To sync_list.Items.Count - 1 Step 1
            Print(1, sync_list.Items(i).SubItems(0).Text + Chr(13))
            Print(1, sync_list.Items(i).SubItems(1).Text + Chr(13))
            Print(1, sync_list.Items(i).SubItems(2).Text + Chr(13))
        Next

        FileClose(1)

    End Sub

    Private Sub load_sync()

        Try
            FileOpen(1, Application.StartupPath + "\suppoting_files\sync.hb", OpenMode.Input)

            While (1)
                Try
                    sync_list.Items.Add(LineInput(1))
                    sync_list.Items(sync_list.Items.Count - 1).SubItems.Add(LineInput(1))
                    sync_list.Items(sync_list.Items.Count - 1).SubItems.Add(LineInput(1))
                Catch
                    Exit While
                End Try
            End While

            FileClose(1)

        Catch
            Try
                FileClose(1)
                Exit Sub
            Catch
            End Try

        End Try

        sync_list.Height = 28 + 20 * sync_list.Items.Count


        Try
            FileOpen(1, Application.StartupPath + "\suppoting_files\sync_sche.hb", OpenMode.Input)

            hr_sync.Value = LineInput(1)
            min_sync.Value = LineInput(1)
            am_pm_sync.SelectedIndex = LineInput(1)
            label_sync.Text = LineInput(1)

            FileClose(1)

            Timer_sync.Enabled = True

        Catch
            Try
                FileClose(1)
                Exit Sub
            Catch
            End Try
        End Try

    End Sub

    'log off, restart etc.

    Private Sub restart_b_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles restart_b.Click
        cmd_command = "cmd.exe /c shutdown.exe /r"
        Timer_sd.Enabled = True
    End Sub

    Private Sub Shut_down_b_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Shut_down_b.Click
        cmd_command = "cmd.exe /c shutdown.exe /p"
        Timer_sd.Enabled = True
    End Sub

    Private Sub Hibernate_b_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hibernate_b.Click
        cmd_command = "cmd.exe /c shutdown.exe /h"
        Timer_sd.Enabled = True
    End Sub

    Private Sub Abort_b_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Abort_b.Click
        Timer_sd.Enabled = False
        Shell("cmd.exe /c shutdown.exe /a", AppWinStyle.Hide)
    End Sub

    Private Sub Log_off_b_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Log_off_b.Click
        cmd_command = "cmd.exe /c shutdown.exe /l"
        Timer_sd.Enabled = True
    End Sub


    Private Sub shut_down_count_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles shut_down_count.TextChanged

        If IsNumeric(shut_down_count.Text) = False Then
            shut_down_count.Text = ""
        End If

    End Sub


    Private Sub Timer_sd_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_sd.Tick

        If sd_timer_ck.Checked = False Then
            Shell(cmd_command, AppWinStyle.Hide)
        Else
            If IsNumeric(shut_down_count.Text) = True Then
                If Timer_sd.Interval <> CInt(shut_down_count.Text) * 1000 + 10 Then
                    Timer_sd.Interval = CInt(shut_down_count.Text) * 1000 + 10
                    Exit Sub
                Else
                    Shell(cmd_command, AppWinStyle.Hide)
                    Timer_sd.Interval = 10
                End If
            End If
        End If

        Timer_sd.Enabled = False

    End Sub

    'power plan

    Private Sub pw_option_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pw_option.Click
        Shell("cmd.exe /c control powercfg.cpl", AppWinStyle.Hide)
    End Sub

    Private Sub pw_refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pw_refresh.Click
        pw_pl.Items.Clear()
        Call load_power()
    End Sub


    Private Sub pw_pl_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pw_pl.SelectedIndexChanged

        Dim cmd_pw As String = "cmd.exe /c powercfg -s "
        Dim i As Integer = pw_pl.SelectedIndex

        Try
            cmd_pw = cmd_pw + pw_guid(i).Substring(pw_guid(i).IndexOf(":") + 2, pw_guid(i).IndexOf("(") - pw_guid(i).IndexOf(":") - 3)
        Catch ex As Exception
            Exit Sub
        End Try

        Shell(cmd_pw, AppWinStyle.Hide)

    End Sub


    Private Sub Timer_pw_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_pw.Tick

        Dim str_pw As String
        Dim i, n As Integer

        n = 0

        If My.Computer.FileSystem.FileExists(Application.StartupPath + "\suppoting_files\power_plan.hb") = False Then
            Exit Sub
        End If

        Timer_pw.Enabled = False

        Try
            FileOpen(1, Application.StartupPath + "\suppoting_files\power_plan.hb", OpenMode.Input)
            str_pw = LineInput(1)
            str_pw = LineInput(1)
            str_pw = LineInput(1)

            While (1)
                ReDim Preserve pw_guid(n)
                pw_guid(n) = LineInput(1)
                n += 1
            End While
        Catch
        End Try

        FileClose(1)

        For i = 0 To n - 1 Step 1
            pw_pl.Items.Add(pw_guid(i).Substring(pw_guid(i).IndexOf("(") + 1, pw_guid(i).IndexOf(")") - pw_guid(i).IndexOf("(") - 1))

            If pw_guid(i).IndexOf("*") >= 0 Then
                pw_pl.SelectedIndex = i
            End If
        Next

    End Sub


    Private Sub load_power()

        Dim fl_name As String = Application.StartupPath + "\suppoting_files\power_plan.hb"
        fl_name = """" + fl_name + """"

        Shell("cmd.exe /c powercfg -list > " + fl_name, AppWinStyle.Hide)

        Timer_pw.Enabled = True

    End Sub

    'proxy

End Class
