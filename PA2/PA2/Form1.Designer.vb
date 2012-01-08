<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.TCtrl = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.restore_task = New System.Windows.Forms.Button
        Me.ref_ex = New System.Windows.Forms.Button
        Me.refresh_pick = New System.Windows.Forms.Button
        Me.delete_pick = New System.Windows.Forms.Button
        Me.shortcut = New System.Windows.Forms.GroupBox
        Me.down = New System.Windows.Forms.Button
        Me.up = New System.Windows.Forms.Button
        Me.open_f = New System.Windows.Forms.Button
        Me.delete_f = New System.Windows.Forms.Button
        Me.edit_f = New System.Windows.Forms.Button
        Me.shortcuts = New System.Windows.Forms.ListBox
        Me.loc_f = New System.Windows.Forms.Label
        Me.add_f = New System.Windows.Forms.Button
        Me.Alarm_list = New System.Windows.Forms.ListBox
        Me.treDirectory = New System.Windows.Forms.TreeView
        Me.alarm = New System.Windows.Forms.GroupBox
        Me.browse_media_al = New System.Windows.Forms.Button
        Me.music_nm_al = New System.Windows.Forms.Label
        Me.browse_al = New System.Windows.Forms.Button
        Me.stop_al = New System.Windows.Forms.Button
        Me.delete_al = New System.Windows.Forms.Button
        Me.hour_al = New System.Windows.Forms.NumericUpDown
        Me.min_al = New System.Windows.Forms.NumericUpDown
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.t1 = New System.Windows.Forms.RadioButton
        Me.t3 = New System.Windows.Forms.RadioButton
        Me.t2 = New System.Windows.Forms.RadioButton
        Me.am_pm_al = New System.Windows.Forms.ComboBox
        Me.start_al = New System.Windows.Forms.Button
        Me.test_al = New System.Windows.Forms.Button
        Me.save_sche = New System.Windows.Forms.Button
        Me.date_pick = New System.Windows.Forms.DateTimePicker
        Me.real_time = New System.Windows.Forms.Label
        Me.calendar = New System.Windows.Forms.MonthCalendar
        Me.task_list = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.naming = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.clr_log = New System.Windows.Forms.Button
        Me.sync_log = New System.Windows.Forms.ListView
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.sync_sche = New System.Windows.Forms.GroupBox
        Me.stop_sync = New System.Windows.Forms.Button
        Me.set_sync = New System.Windows.Forms.Button
        Me.label_sync = New System.Windows.Forms.Label
        Me.hr_sync = New System.Windows.Forms.NumericUpDown
        Me.min_sync = New System.Windows.Forms.NumericUpDown
        Me.am_pm_sync = New System.Windows.Forms.ComboBox
        Me.remove_sync = New System.Windows.Forms.Button
        Me.Add_sync = New System.Windows.Forms.Button
        Me.sync_list = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.action_sync_bx = New System.Windows.Forms.GroupBox
        Me.mrg_sr = New System.Windows.Forms.RadioButton
        Me.Button1 = New System.Windows.Forms.Button
        Me.mrg_des = New System.Windows.Forms.RadioButton
        Me.ovw_des = New System.Windows.Forms.RadioButton
        Me.ovw_sr = New System.Windows.Forms.RadioButton
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.Webpage = New System.Windows.Forms.TabControl
        Me.Menu_browser = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintPreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseCurrentTabToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseOtherTabsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ShowHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RecentlyClosedTabToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RecentPagesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClearHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GoBackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GoForwardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.history = New System.Windows.Forms.ToolStripComboBox
        Me.AddTabToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseCurrentTabToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.Computation_bx = New System.Windows.Forms.GroupBox
        Me.core_label = New System.Windows.Forms.Label
        Me.core_val = New System.Windows.Forms.NumericUpDown
        Me.end_all_comp = New System.Windows.Forms.Button
        Me.end_lt_comp = New System.Windows.Forms.Button
        Me.task_mn_box = New System.Windows.Forms.GroupBox
        Me.close_process = New System.Windows.Forms.Button
        Me.all_pro = New System.Windows.Forms.CheckBox
        Me.end_process = New System.Windows.Forms.Button
        Me.pro_count = New System.Windows.Forms.Label
        Me.refr_task_mn = New System.Windows.Forms.CheckBox
        Me.px_bx = New System.Windows.Forms.GroupBox
        Me.ie_px = New System.Windows.Forms.ComboBox
        Me.ie_p_label = New System.Windows.Forms.Label
        Me.power = New System.Windows.Forms.GroupBox
        Me.pw_refresh = New System.Windows.Forms.Button
        Me.pw_option = New System.Windows.Forms.Button
        Me.pw_pl = New System.Windows.Forms.ComboBox
        Me.shutdown = New System.Windows.Forms.GroupBox
        Me.restart_b = New System.Windows.Forms.Button
        Me.Label_sd = New System.Windows.Forms.Label
        Me.sd_timer_ck = New System.Windows.Forms.CheckBox
        Me.shut_down_count = New System.Windows.Forms.TextBox
        Me.Shut_down_b = New System.Windows.Forms.Button
        Me.Log_off_b = New System.Windows.Forms.Button
        Me.Hibernate_b = New System.Windows.Forms.Button
        Me.Abort_b = New System.Windows.Forms.Button
        Me.maxb_en = New System.Windows.Forms.CheckBox
        Me.top_most = New System.Windows.Forms.CheckBox
        Me.task_manager = New System.Windows.Forms.DataGridView
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Timer_keep = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_play = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_al = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_refresh = New System.Windows.Forms.Timer(Me.components)
        Me.folder_browse = New System.Windows.Forms.FolderBrowserDialog
        Me.Timer_al_refresh = New System.Windows.Forms.Timer(Me.components)
        Me.File_browse = New System.Windows.Forms.OpenFileDialog
        Me.Timer_browser = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_process = New System.Windows.Forms.Timer(Me.components)
        Me.file_save = New System.Windows.Forms.SaveFileDialog
        Me.Timer_sync = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_br_refresh = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_sd = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_pw = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_fd_size = New System.Windows.Forms.Timer(Me.components)
        Me.TCtrl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.shortcut.SuspendLayout()
        Me.alarm.SuspendLayout()
        CType(Me.hour_al, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.min_al, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.task_list, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.sync_sche.SuspendLayout()
        CType(Me.hr_sync, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.min_sync, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.action_sync_bx.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Menu_browser.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.Computation_bx.SuspendLayout()
        CType(Me.core_val, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.task_mn_box.SuspendLayout()
        Me.px_bx.SuspendLayout()
        Me.power.SuspendLayout()
        Me.shutdown.SuspendLayout()
        CType(Me.task_manager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TCtrl
        '
        Me.TCtrl.Controls.Add(Me.TabPage1)
        Me.TCtrl.Controls.Add(Me.TabPage2)
        Me.TCtrl.Controls.Add(Me.TabPage3)
        Me.TCtrl.Controls.Add(Me.TabPage4)
        Me.TCtrl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TCtrl.Location = New System.Drawing.Point(0, 0)
        Me.TCtrl.Name = "TCtrl"
        Me.TCtrl.SelectedIndex = 0
        Me.TCtrl.Size = New System.Drawing.Size(1276, 706)
        Me.TCtrl.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.restore_task)
        Me.TabPage1.Controls.Add(Me.ref_ex)
        Me.TabPage1.Controls.Add(Me.refresh_pick)
        Me.TabPage1.Controls.Add(Me.delete_pick)
        Me.TabPage1.Controls.Add(Me.shortcut)
        Me.TabPage1.Controls.Add(Me.Alarm_list)
        Me.TabPage1.Controls.Add(Me.treDirectory)
        Me.TabPage1.Controls.Add(Me.alarm)
        Me.TabPage1.Controls.Add(Me.save_sche)
        Me.TabPage1.Controls.Add(Me.date_pick)
        Me.TabPage1.Controls.Add(Me.real_time)
        Me.TabPage1.Controls.Add(Me.calendar)
        Me.TabPage1.Controls.Add(Me.task_list)
        Me.TabPage1.Controls.Add(Me.naming)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1268, 680)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Home"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'restore_task
        '
        Me.restore_task.Location = New System.Drawing.Point(1170, 645)
        Me.restore_task.Name = "restore_task"
        Me.restore_task.Size = New System.Drawing.Size(154, 32)
        Me.restore_task.TabIndex = 37
        Me.restore_task.Text = "Restore last stored database"
        Me.restore_task.UseVisualStyleBackColor = True
        '
        'ref_ex
        '
        Me.ref_ex.Location = New System.Drawing.Point(414, 448)
        Me.ref_ex.Name = "ref_ex"
        Me.ref_ex.Size = New System.Drawing.Size(65, 33)
        Me.ref_ex.TabIndex = 36
        Me.ref_ex.Text = "Refresh"
        Me.ref_ex.UseVisualStyleBackColor = True
        '
        'refresh_pick
        '
        Me.refresh_pick.Location = New System.Drawing.Point(1202, 606)
        Me.refresh_pick.Name = "refresh_pick"
        Me.refresh_pick.Size = New System.Drawing.Size(71, 33)
        Me.refresh_pick.TabIndex = 35
        Me.refresh_pick.Text = "Refresh"
        Me.refresh_pick.UseVisualStyleBackColor = True
        '
        'delete_pick
        '
        Me.delete_pick.Location = New System.Drawing.Point(1275, 606)
        Me.delete_pick.Name = "delete_pick"
        Me.delete_pick.Size = New System.Drawing.Size(71, 33)
        Me.delete_pick.TabIndex = 34
        Me.delete_pick.Text = "Remove"
        Me.delete_pick.UseVisualStyleBackColor = True
        '
        'shortcut
        '
        Me.shortcut.Controls.Add(Me.down)
        Me.shortcut.Controls.Add(Me.up)
        Me.shortcut.Controls.Add(Me.open_f)
        Me.shortcut.Controls.Add(Me.delete_f)
        Me.shortcut.Controls.Add(Me.edit_f)
        Me.shortcut.Controls.Add(Me.shortcuts)
        Me.shortcut.Controls.Add(Me.loc_f)
        Me.shortcut.Controls.Add(Me.add_f)
        Me.shortcut.Location = New System.Drawing.Point(8, 109)
        Me.shortcut.Name = "shortcut"
        Me.shortcut.Size = New System.Drawing.Size(371, 328)
        Me.shortcut.TabIndex = 32
        Me.shortcut.TabStop = False
        Me.shortcut.Text = "Important Shortcuts"
        '
        'down
        '
        Me.down.Location = New System.Drawing.Point(275, 206)
        Me.down.Name = "down"
        Me.down.Size = New System.Drawing.Size(65, 33)
        Me.down.TabIndex = 37
        Me.down.Text = "Down"
        Me.down.UseVisualStyleBackColor = True
        '
        'up
        '
        Me.up.Location = New System.Drawing.Point(275, 164)
        Me.up.Name = "up"
        Me.up.Size = New System.Drawing.Size(65, 33)
        Me.up.TabIndex = 36
        Me.up.Text = "Up"
        Me.up.UseVisualStyleBackColor = True
        '
        'open_f
        '
        Me.open_f.Location = New System.Drawing.Point(275, 30)
        Me.open_f.Name = "open_f"
        Me.open_f.Size = New System.Drawing.Size(65, 33)
        Me.open_f.TabIndex = 35
        Me.open_f.Text = "Open"
        Me.open_f.UseVisualStyleBackColor = True
        '
        'delete_f
        '
        Me.delete_f.Location = New System.Drawing.Point(275, 250)
        Me.delete_f.Name = "delete_f"
        Me.delete_f.Size = New System.Drawing.Size(65, 33)
        Me.delete_f.TabIndex = 34
        Me.delete_f.Text = "Delete"
        Me.delete_f.UseVisualStyleBackColor = True
        '
        'edit_f
        '
        Me.edit_f.Location = New System.Drawing.Point(275, 121)
        Me.edit_f.Name = "edit_f"
        Me.edit_f.Size = New System.Drawing.Size(65, 33)
        Me.edit_f.TabIndex = 32
        Me.edit_f.Text = "Modify"
        Me.edit_f.UseVisualStyleBackColor = True
        '
        'shortcuts
        '
        Me.shortcuts.FormattingEnabled = True
        Me.shortcuts.Location = New System.Drawing.Point(22, 32)
        Me.shortcuts.Name = "shortcuts"
        Me.shortcuts.Size = New System.Drawing.Size(225, 251)
        Me.shortcuts.TabIndex = 28
        '
        'loc_f
        '
        Me.loc_f.AutoSize = True
        Me.loc_f.Location = New System.Drawing.Point(6, 298)
        Me.loc_f.Name = "loc_f"
        Me.loc_f.Size = New System.Drawing.Size(49, 13)
        Me.loc_f.TabIndex = 29
        Me.loc_f.Text = "Directory"
        '
        'add_f
        '
        Me.add_f.Location = New System.Drawing.Point(275, 76)
        Me.add_f.Name = "add_f"
        Me.add_f.Size = New System.Drawing.Size(65, 33)
        Me.add_f.TabIndex = 30
        Me.add_f.Text = "Add"
        Me.add_f.UseVisualStyleBackColor = True
        '
        'Alarm_list
        '
        Me.Alarm_list.FormattingEnabled = True
        Me.Alarm_list.Location = New System.Drawing.Point(1138, 228)
        Me.Alarm_list.Name = "Alarm_list"
        Me.Alarm_list.Size = New System.Drawing.Size(197, 69)
        Me.Alarm_list.TabIndex = 27
        '
        'treDirectory
        '
        Me.treDirectory.Location = New System.Drawing.Point(414, 115)
        Me.treDirectory.Name = "treDirectory"
        Me.treDirectory.Size = New System.Drawing.Size(678, 322)
        Me.treDirectory.TabIndex = 33
        '
        'alarm
        '
        Me.alarm.Controls.Add(Me.browse_media_al)
        Me.alarm.Controls.Add(Me.music_nm_al)
        Me.alarm.Controls.Add(Me.browse_al)
        Me.alarm.Controls.Add(Me.stop_al)
        Me.alarm.Controls.Add(Me.delete_al)
        Me.alarm.Controls.Add(Me.hour_al)
        Me.alarm.Controls.Add(Me.min_al)
        Me.alarm.Controls.Add(Me.GroupBox1)
        Me.alarm.Controls.Add(Me.am_pm_al)
        Me.alarm.Controls.Add(Me.start_al)
        Me.alarm.Controls.Add(Me.test_al)
        Me.alarm.Location = New System.Drawing.Point(1136, 317)
        Me.alarm.Name = "alarm"
        Me.alarm.Size = New System.Drawing.Size(208, 238)
        Me.alarm.TabIndex = 26
        Me.alarm.TabStop = False
        Me.alarm.Text = "Set Alarm"
        '
        'browse_media_al
        '
        Me.browse_media_al.Location = New System.Drawing.Point(66, 167)
        Me.browse_media_al.Name = "browse_media_al"
        Me.browse_media_al.Size = New System.Drawing.Size(78, 33)
        Me.browse_media_al.TabIndex = 37
        Me.browse_media_al.Text = "Media Player"
        Me.browse_media_al.UseVisualStyleBackColor = True
        '
        'music_nm_al
        '
        Me.music_nm_al.AutoSize = True
        Me.music_nm_al.Location = New System.Drawing.Point(11, 214)
        Me.music_nm_al.Name = "music_nm_al"
        Me.music_nm_al.Size = New System.Drawing.Size(63, 13)
        Me.music_nm_al.TabIndex = 36
        Me.music_nm_al.Text = "music1.wav"
        '
        'browse_al
        '
        Me.browse_al.Location = New System.Drawing.Point(146, 119)
        Me.browse_al.Name = "browse_al"
        Me.browse_al.Size = New System.Drawing.Size(60, 33)
        Me.browse_al.TabIndex = 36
        Me.browse_al.Text = "Browse"
        Me.browse_al.UseVisualStyleBackColor = True
        '
        'stop_al
        '
        Me.stop_al.Location = New System.Drawing.Point(146, 167)
        Me.stop_al.Name = "stop_al"
        Me.stop_al.Size = New System.Drawing.Size(60, 33)
        Me.stop_al.TabIndex = 27
        Me.stop_al.Text = "Stop"
        Me.stop_al.UseVisualStyleBackColor = True
        '
        'delete_al
        '
        Me.delete_al.Location = New System.Drawing.Point(76, 119)
        Me.delete_al.Name = "delete_al"
        Me.delete_al.Size = New System.Drawing.Size(60, 33)
        Me.delete_al.TabIndex = 26
        Me.delete_al.Text = "Remove"
        Me.delete_al.UseVisualStyleBackColor = True
        '
        'hour_al
        '
        Me.hour_al.Location = New System.Drawing.Point(20, 24)
        Me.hour_al.Name = "hour_al"
        Me.hour_al.Size = New System.Drawing.Size(50, 20)
        Me.hour_al.TabIndex = 18
        '
        'min_al
        '
        Me.min_al.Location = New System.Drawing.Point(76, 24)
        Me.min_al.Name = "min_al"
        Me.min_al.Size = New System.Drawing.Size(50, 20)
        Me.min_al.TabIndex = 19
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.t1)
        Me.GroupBox1.Controls.Add(Me.t3)
        Me.GroupBox1.Controls.Add(Me.t2)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(175, 57)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Snooze time_out"
        '
        't1
        '
        Me.t1.AutoSize = True
        Me.t1.Checked = True
        Me.t1.Location = New System.Drawing.Point(8, 22)
        Me.t1.Name = "t1"
        Me.t1.Size = New System.Drawing.Size(53, 17)
        Me.t1.TabIndex = 6
        Me.t1.TabStop = True
        Me.t1.Text = "5 min."
        Me.t1.UseVisualStyleBackColor = True
        '
        't3
        '
        Me.t3.AutoSize = True
        Me.t3.Location = New System.Drawing.Point(120, 22)
        Me.t3.Name = "t3"
        Me.t3.Size = New System.Drawing.Size(59, 17)
        Me.t3.TabIndex = 8
        Me.t3.TabStop = True
        Me.t3.Text = "20 min."
        Me.t3.UseVisualStyleBackColor = True
        '
        't2
        '
        Me.t2.AutoSize = True
        Me.t2.Location = New System.Drawing.Point(61, 22)
        Me.t2.Name = "t2"
        Me.t2.Size = New System.Drawing.Size(59, 17)
        Me.t2.TabIndex = 7
        Me.t2.Text = "10 min."
        Me.t2.UseVisualStyleBackColor = True
        '
        'am_pm_al
        '
        Me.am_pm_al.FormattingEnabled = True
        Me.am_pm_al.Location = New System.Drawing.Point(132, 23)
        Me.am_pm_al.Name = "am_pm_al"
        Me.am_pm_al.Size = New System.Drawing.Size(60, 21)
        Me.am_pm_al.TabIndex = 20
        '
        'start_al
        '
        Me.start_al.Location = New System.Drawing.Point(3, 119)
        Me.start_al.Name = "start_al"
        Me.start_al.Size = New System.Drawing.Size(60, 33)
        Me.start_al.TabIndex = 21
        Me.start_al.Text = "Add"
        Me.start_al.UseVisualStyleBackColor = True
        '
        'test_al
        '
        Me.test_al.Location = New System.Drawing.Point(3, 167)
        Me.test_al.Name = "test_al"
        Me.test_al.Size = New System.Drawing.Size(60, 33)
        Me.test_al.TabIndex = 23
        Me.test_al.Text = "Test"
        Me.test_al.UseVisualStyleBackColor = True
        '
        'save_sche
        '
        Me.save_sche.Location = New System.Drawing.Point(1128, 606)
        Me.save_sche.Name = "save_sche"
        Me.save_sche.Size = New System.Drawing.Size(71, 33)
        Me.save_sche.TabIndex = 17
        Me.save_sche.Text = "Save"
        Me.save_sche.UseVisualStyleBackColor = True
        '
        'date_pick
        '
        Me.date_pick.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.date_pick.Location = New System.Drawing.Point(1142, 576)
        Me.date_pick.Name = "date_pick"
        Me.date_pick.Size = New System.Drawing.Size(200, 20)
        Me.date_pick.TabIndex = 16
        '
        'real_time
        '
        Me.real_time.AutoSize = True
        Me.real_time.Location = New System.Drawing.Point(1174, 192)
        Me.real_time.Name = "real_time"
        Me.real_time.Size = New System.Drawing.Size(137, 13)
        Me.real_time.TabIndex = 15
        Me.real_time.Text = "Current Time : hh.mm.ss pm"
        '
        'calendar
        '
        Me.calendar.Location = New System.Drawing.Point(1117, 21)
        Me.calendar.Name = "calendar"
        Me.calendar.TabIndex = 3
        '
        'task_list
        '
        Me.task_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.task_list.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column3, Me.Column4, Me.Column5})
        Me.task_list.Location = New System.Drawing.Point(0, 487)
        Me.task_list.MultiSelect = False
        Me.task_list.Name = "task_list"
        Me.task_list.Size = New System.Drawing.Size(1092, 193)
        Me.task_list.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.HeaderText = "Date and Time"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 155
        '
        'Column3
        '
        Me.Column3.HeaderText = "Task"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 500
        '
        'Column4
        '
        Me.Column4.HeaderText = "Deadline"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 150
        '
        'Column5
        '
        Me.Column5.HeaderText = "Remarks"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 240
        '
        'naming
        '
        Me.naming.AutoSize = True
        Me.naming.BackColor = System.Drawing.Color.White
        Me.naming.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.naming.ForeColor = System.Drawing.Color.Blue
        Me.naming.Location = New System.Drawing.Point(475, 21)
        Me.naming.Name = "naming"
        Me.naming.Size = New System.Drawing.Size(256, 39)
        Me.naming.TabIndex = 1
        Me.naming.Text = "Welcome Hiranmoy"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.clr_log)
        Me.TabPage2.Controls.Add(Me.sync_log)
        Me.TabPage2.Controls.Add(Me.sync_sche)
        Me.TabPage2.Controls.Add(Me.remove_sync)
        Me.TabPage2.Controls.Add(Me.Add_sync)
        Me.TabPage2.Controls.Add(Me.sync_list)
        Me.TabPage2.Controls.Add(Me.action_sync_bx)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1268, 680)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Synchronise"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'clr_log
        '
        Me.clr_log.Location = New System.Drawing.Point(707, 614)
        Me.clr_log.Name = "clr_log"
        Me.clr_log.Size = New System.Drawing.Size(87, 28)
        Me.clr_log.TabIndex = 30
        Me.clr_log.Text = "Clear list"
        Me.clr_log.UseVisualStyleBackColor = True
        '
        'sync_log
        '
        Me.sync_log.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader5})
        Me.sync_log.Location = New System.Drawing.Point(910, 357)
        Me.sync_log.MultiSelect = False
        Me.sync_log.Name = "sync_log"
        Me.sync_log.Size = New System.Drawing.Size(436, 317)
        Me.sync_log.TabIndex = 28
        Me.sync_log.UseCompatibleStateImageBehavior = False
        Me.sync_log.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Last Sync attempts"
        Me.ColumnHeader4.Width = 328
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Successful"
        Me.ColumnHeader5.Width = 100
        '
        'sync_sche
        '
        Me.sync_sche.Controls.Add(Me.stop_sync)
        Me.sync_sche.Controls.Add(Me.set_sync)
        Me.sync_sche.Controls.Add(Me.label_sync)
        Me.sync_sche.Controls.Add(Me.hr_sync)
        Me.sync_sche.Controls.Add(Me.min_sync)
        Me.sync_sche.Controls.Add(Me.am_pm_sync)
        Me.sync_sche.Location = New System.Drawing.Point(643, 387)
        Me.sync_sche.Name = "sync_sche"
        Me.sync_sche.Size = New System.Drawing.Size(208, 153)
        Me.sync_sche.TabIndex = 27
        Me.sync_sche.TabStop = False
        Me.sync_sche.Text = "Set Synchronisation Schedule"
        '
        'stop_sync
        '
        Me.stop_sync.Location = New System.Drawing.Point(115, 113)
        Me.stop_sync.Name = "stop_sync"
        Me.stop_sync.Size = New System.Drawing.Size(87, 28)
        Me.stop_sync.TabIndex = 31
        Me.stop_sync.Text = "Stop sync"
        Me.stop_sync.UseVisualStyleBackColor = True
        '
        'set_sync
        '
        Me.set_sync.Location = New System.Drawing.Point(6, 113)
        Me.set_sync.Name = "set_sync"
        Me.set_sync.Size = New System.Drawing.Size(87, 28)
        Me.set_sync.TabIndex = 29
        Me.set_sync.Text = "Set time"
        Me.set_sync.UseVisualStyleBackColor = True
        '
        'label_sync
        '
        Me.label_sync.AutoSize = True
        Me.label_sync.Location = New System.Drawing.Point(10, 63)
        Me.label_sync.Name = "label_sync"
        Me.label_sync.Size = New System.Drawing.Size(93, 13)
        Me.label_sync.TabIndex = 28
        Me.label_sync.Text = "Current schedule -"
        '
        'hr_sync
        '
        Me.hr_sync.Location = New System.Drawing.Point(20, 24)
        Me.hr_sync.Name = "hr_sync"
        Me.hr_sync.Size = New System.Drawing.Size(50, 20)
        Me.hr_sync.TabIndex = 18
        '
        'min_sync
        '
        Me.min_sync.Location = New System.Drawing.Point(76, 24)
        Me.min_sync.Name = "min_sync"
        Me.min_sync.Size = New System.Drawing.Size(50, 20)
        Me.min_sync.TabIndex = 19
        '
        'am_pm_sync
        '
        Me.am_pm_sync.FormattingEnabled = True
        Me.am_pm_sync.Location = New System.Drawing.Point(132, 23)
        Me.am_pm_sync.Name = "am_pm_sync"
        Me.am_pm_sync.Size = New System.Drawing.Size(60, 21)
        Me.am_pm_sync.TabIndex = 20
        '
        'remove_sync
        '
        Me.remove_sync.Location = New System.Drawing.Point(118, 326)
        Me.remove_sync.Name = "remove_sync"
        Me.remove_sync.Size = New System.Drawing.Size(92, 29)
        Me.remove_sync.TabIndex = 5
        Me.remove_sync.Text = "Remove folder"
        Me.remove_sync.UseVisualStyleBackColor = True
        '
        'Add_sync
        '
        Me.Add_sync.Location = New System.Drawing.Point(8, 326)
        Me.Add_sync.Name = "Add_sync"
        Me.Add_sync.Size = New System.Drawing.Size(92, 29)
        Me.Add_sync.TabIndex = 4
        Me.Add_sync.Text = "Add folder"
        Me.Add_sync.UseVisualStyleBackColor = True
        '
        'sync_list
        '
        Me.sync_list.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.sync_list.Dock = System.Windows.Forms.DockStyle.Top
        Me.sync_list.Location = New System.Drawing.Point(3, 3)
        Me.sync_list.MultiSelect = False
        Me.sync_list.Name = "sync_list"
        Me.sync_list.Size = New System.Drawing.Size(1262, 29)
        Me.sync_list.TabIndex = 2
        Me.sync_list.UseCompatibleStateImageBehavior = False
        Me.sync_list.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Sync_folder_Name"
        Me.ColumnHeader1.Width = 375
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Sync_destination"
        Me.ColumnHeader2.Width = 434
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Last time synchronised"
        Me.ColumnHeader3.Width = 231
        '
        'action_sync_bx
        '
        Me.action_sync_bx.Controls.Add(Me.mrg_sr)
        Me.action_sync_bx.Controls.Add(Me.Button1)
        Me.action_sync_bx.Controls.Add(Me.mrg_des)
        Me.action_sync_bx.Controls.Add(Me.ovw_des)
        Me.action_sync_bx.Controls.Add(Me.ovw_sr)
        Me.action_sync_bx.Location = New System.Drawing.Point(22, 431)
        Me.action_sync_bx.Name = "action_sync_bx"
        Me.action_sync_bx.Size = New System.Drawing.Size(253, 210)
        Me.action_sync_bx.TabIndex = 24
        Me.action_sync_bx.TabStop = False
        Me.action_sync_bx.Text = "Action"
        '
        'mrg_sr
        '
        Me.mrg_sr.AutoSize = True
        Me.mrg_sr.Location = New System.Drawing.Point(6, 92)
        Me.mrg_sr.Name = "mrg_sr"
        Me.mrg_sr.Size = New System.Drawing.Size(160, 17)
        Me.mrg_sr.TabIndex = 29
        Me.mrg_sr.Text = "Merge with destination folder"
        Me.mrg_sr.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(74, 167)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 28)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Apply"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'mrg_des
        '
        Me.mrg_des.AutoSize = True
        Me.mrg_des.Location = New System.Drawing.Point(6, 45)
        Me.mrg_des.Name = "mrg_des"
        Me.mrg_des.Size = New System.Drawing.Size(160, 17)
        Me.mrg_des.TabIndex = 6
        Me.mrg_des.Text = "Merge with destination folder"
        Me.mrg_des.UseVisualStyleBackColor = True
        '
        'ovw_des
        '
        Me.ovw_des.AutoSize = True
        Me.ovw_des.Checked = True
        Me.ovw_des.Location = New System.Drawing.Point(6, 19)
        Me.ovw_des.Name = "ovw_des"
        Me.ovw_des.Size = New System.Drawing.Size(185, 17)
        Me.ovw_des.TabIndex = 8
        Me.ovw_des.TabStop = True
        Me.ovw_des.Text = "Overwrite files in destination folder"
        Me.ovw_des.UseVisualStyleBackColor = True
        '
        'ovw_sr
        '
        Me.ovw_sr.AutoSize = True
        Me.ovw_sr.Location = New System.Drawing.Point(6, 68)
        Me.ovw_sr.Name = "ovw_sr"
        Me.ovw_sr.Size = New System.Drawing.Size(166, 17)
        Me.ovw_sr.TabIndex = 7
        Me.ovw_sr.Text = "Overwrite files in source folder"
        Me.ovw_sr.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Webpage)
        Me.TabPage3.Controls.Add(Me.Menu_browser)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1354, 680)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Browser"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Webpage
        '
        Me.Webpage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Webpage.Location = New System.Drawing.Point(3, 30)
        Me.Webpage.Name = "Webpage"
        Me.Webpage.SelectedIndex = 0
        Me.Webpage.Size = New System.Drawing.Size(1348, 647)
        Me.Webpage.TabIndex = 1
        '
        'Menu_browser
        '
        Me.Menu_browser.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HistoryToolStripMenuItem, Me.GoBackToolStripMenuItem, Me.GoForwardToolStripMenuItem, Me.RefreshToolStripMenuItem, Me.StopToolStripMenuItem, Me.SearchToolStripMenuItem, Me.GoToolStripMenuItem, Me.history, Me.AddTabToolStripMenuItem, Me.CloseCurrentTabToolStripMenuItem2})
        Me.Menu_browser.Location = New System.Drawing.Point(3, 3)
        Me.Menu_browser.Name = "Menu_browser"
        Me.Menu_browser.ShowItemToolTips = True
        Me.Menu_browser.Size = New System.Drawing.Size(1348, 27)
        Me.Menu_browser.TabIndex = 0
        Me.Menu_browser.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.PrintPreviewToolStripMenuItem, Me.PrintToolStripMenuItem, Me.CloseCurrentTabToolStripMenuItem, Me.CloseOtherTabsToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 23)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save As"
        '
        'PrintPreviewToolStripMenuItem
        '
        Me.PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
        Me.PrintPreviewToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.PrintPreviewToolStripMenuItem.Text = "Print Preview"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'CloseCurrentTabToolStripMenuItem
        '
        Me.CloseCurrentTabToolStripMenuItem.Name = "CloseCurrentTabToolStripMenuItem"
        Me.CloseCurrentTabToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.CloseCurrentTabToolStripMenuItem.Text = "Close current Tab"
        '
        'CloseOtherTabsToolStripMenuItem
        '
        Me.CloseOtherTabsToolStripMenuItem.Name = "CloseOtherTabsToolStripMenuItem"
        Me.CloseOtherTabsToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.CloseOtherTabsToolStripMenuItem.Text = "Close other Tabs"
        '
        'HistoryToolStripMenuItem
        '
        Me.HistoryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowHistoryToolStripMenuItem, Me.RecentlyClosedTabToolStripMenuItem, Me.RecentPagesToolStripMenuItem, Me.ClearHistoryToolStripMenuItem})
        Me.HistoryToolStripMenuItem.Name = "HistoryToolStripMenuItem"
        Me.HistoryToolStripMenuItem.Size = New System.Drawing.Size(57, 23)
        Me.HistoryToolStripMenuItem.Text = "History"
        '
        'ShowHistoryToolStripMenuItem
        '
        Me.ShowHistoryToolStripMenuItem.Name = "ShowHistoryToolStripMenuItem"
        Me.ShowHistoryToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ShowHistoryToolStripMenuItem.Text = "Show history"
        '
        'RecentlyClosedTabToolStripMenuItem
        '
        Me.RecentlyClosedTabToolStripMenuItem.Name = "RecentlyClosedTabToolStripMenuItem"
        Me.RecentlyClosedTabToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.RecentlyClosedTabToolStripMenuItem.Text = "Recently closed tabs"
        '
        'RecentPagesToolStripMenuItem
        '
        Me.RecentPagesToolStripMenuItem.Name = "RecentPagesToolStripMenuItem"
        Me.RecentPagesToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.RecentPagesToolStripMenuItem.Text = "Recent pages"
        '
        'ClearHistoryToolStripMenuItem
        '
        Me.ClearHistoryToolStripMenuItem.Name = "ClearHistoryToolStripMenuItem"
        Me.ClearHistoryToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ClearHistoryToolStripMenuItem.Text = "Clear history"
        '
        'GoBackToolStripMenuItem
        '
        Me.GoBackToolStripMenuItem.Name = "GoBackToolStripMenuItem"
        Me.GoBackToolStripMenuItem.Size = New System.Drawing.Size(62, 23)
        Me.GoBackToolStripMenuItem.Text = "Go Back"
        '
        'GoForwardToolStripMenuItem
        '
        Me.GoForwardToolStripMenuItem.Name = "GoForwardToolStripMenuItem"
        Me.GoForwardToolStripMenuItem.Size = New System.Drawing.Size(78, 23)
        Me.GoForwardToolStripMenuItem.Text = "Go forward"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(58, 23)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'StopToolStripMenuItem
        '
        Me.StopToolStripMenuItem.Name = "StopToolStripMenuItem"
        Me.StopToolStripMenuItem.Size = New System.Drawing.Size(43, 23)
        Me.StopToolStripMenuItem.Text = "Stop"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(54, 23)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'GoToolStripMenuItem
        '
        Me.GoToolStripMenuItem.Name = "GoToolStripMenuItem"
        Me.GoToolStripMenuItem.Size = New System.Drawing.Size(34, 23)
        Me.GoToolStripMenuItem.Text = "Go"
        '
        'history
        '
        Me.history.Name = "history"
        Me.history.Size = New System.Drawing.Size(700, 23)
        '
        'AddTabToolStripMenuItem
        '
        Me.AddTabToolStripMenuItem.Name = "AddTabToolStripMenuItem"
        Me.AddTabToolStripMenuItem.Size = New System.Drawing.Size(64, 23)
        Me.AddTabToolStripMenuItem.Text = "Add Tab"
        '
        'CloseCurrentTabToolStripMenuItem2
        '
        Me.CloseCurrentTabToolStripMenuItem2.Name = "CloseCurrentTabToolStripMenuItem2"
        Me.CloseCurrentTabToolStripMenuItem2.Size = New System.Drawing.Size(112, 23)
        Me.CloseCurrentTabToolStripMenuItem2.Text = "Close current Tab"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Computation_bx)
        Me.TabPage4.Controls.Add(Me.task_mn_box)
        Me.TabPage4.Controls.Add(Me.px_bx)
        Me.TabPage4.Controls.Add(Me.power)
        Me.TabPage4.Controls.Add(Me.shutdown)
        Me.TabPage4.Controls.Add(Me.maxb_en)
        Me.TabPage4.Controls.Add(Me.top_most)
        Me.TabPage4.Controls.Add(Me.task_manager)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1354, 680)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Advanced_control"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Computation_bx
        '
        Me.Computation_bx.Controls.Add(Me.core_label)
        Me.Computation_bx.Controls.Add(Me.core_val)
        Me.Computation_bx.Controls.Add(Me.end_all_comp)
        Me.Computation_bx.Controls.Add(Me.end_lt_comp)
        Me.Computation_bx.Location = New System.Drawing.Point(14, 13)
        Me.Computation_bx.Name = "Computation_bx"
        Me.Computation_bx.Size = New System.Drawing.Size(481, 100)
        Me.Computation_bx.TabIndex = 23
        Me.Computation_bx.TabStop = False
        Me.Computation_bx.Text = "Computation"
        '
        'core_label
        '
        Me.core_label.AutoSize = True
        Me.core_label.Location = New System.Drawing.Point(19, 31)
        Me.core_label.Name = "core_label"
        Me.core_label.Size = New System.Drawing.Size(245, 13)
        Me.core_label.TabIndex = 4
        Me.core_label.Text = "Number of CPU cores to be used for computation :"
        '
        'core_val
        '
        Me.core_val.Location = New System.Drawing.Point(270, 29)
        Me.core_val.Name = "core_val"
        Me.core_val.Size = New System.Drawing.Size(40, 20)
        Me.core_val.TabIndex = 5
        Me.core_val.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'end_all_comp
        '
        Me.end_all_comp.Location = New System.Drawing.Point(338, 63)
        Me.end_all_comp.Name = "end_all_comp"
        Me.end_all_comp.Size = New System.Drawing.Size(129, 27)
        Me.end_all_comp.TabIndex = 21
        Me.end_all_comp.Text = "End all computations"
        Me.end_all_comp.UseVisualStyleBackColor = True
        '
        'end_lt_comp
        '
        Me.end_lt_comp.Location = New System.Drawing.Point(338, 22)
        Me.end_lt_comp.Name = "end_lt_comp"
        Me.end_lt_comp.Size = New System.Drawing.Size(129, 27)
        Me.end_lt_comp.TabIndex = 20
        Me.end_lt_comp.Text = "End latest computation"
        Me.end_lt_comp.UseVisualStyleBackColor = True
        '
        'task_mn_box
        '
        Me.task_mn_box.Controls.Add(Me.close_process)
        Me.task_mn_box.Controls.Add(Me.all_pro)
        Me.task_mn_box.Controls.Add(Me.end_process)
        Me.task_mn_box.Controls.Add(Me.pro_count)
        Me.task_mn_box.Controls.Add(Me.refr_task_mn)
        Me.task_mn_box.Location = New System.Drawing.Point(546, 13)
        Me.task_mn_box.Name = "task_mn_box"
        Me.task_mn_box.Size = New System.Drawing.Size(162, 207)
        Me.task_mn_box.TabIndex = 22
        Me.task_mn_box.TabStop = False
        Me.task_mn_box.Text = "Task manager"
        '
        'close_process
        '
        Me.close_process.Location = New System.Drawing.Point(21, 96)
        Me.close_process.Name = "close_process"
        Me.close_process.Size = New System.Drawing.Size(91, 31)
        Me.close_process.TabIndex = 24
        Me.close_process.Text = "Close window"
        Me.close_process.UseVisualStyleBackColor = True
        '
        'all_pro
        '
        Me.all_pro.AutoSize = True
        Me.all_pro.Location = New System.Drawing.Point(23, 176)
        Me.all_pro.Name = "all_pro"
        Me.all_pro.Size = New System.Drawing.Size(117, 17)
        Me.all_pro.TabIndex = 24
        Me.all_pro.Text = "Show all processes"
        Me.all_pro.UseVisualStyleBackColor = True
        '
        'end_process
        '
        Me.end_process.Location = New System.Drawing.Point(23, 53)
        Me.end_process.Name = "end_process"
        Me.end_process.Size = New System.Drawing.Size(89, 27)
        Me.end_process.TabIndex = 1
        Me.end_process.Text = "End process"
        Me.end_process.UseVisualStyleBackColor = True
        '
        'pro_count
        '
        Me.pro_count.AutoSize = True
        Me.pro_count.Location = New System.Drawing.Point(20, 30)
        Me.pro_count.Name = "pro_count"
        Me.pro_count.Size = New System.Drawing.Size(112, 13)
        Me.pro_count.TabIndex = 2
        Me.pro_count.Text = "Important Processes : "
        '
        'refr_task_mn
        '
        Me.refr_task_mn.AutoSize = True
        Me.refr_task_mn.Checked = True
        Me.refr_task_mn.CheckState = System.Windows.Forms.CheckState.Checked
        Me.refr_task_mn.Location = New System.Drawing.Point(23, 147)
        Me.refr_task_mn.Name = "refr_task_mn"
        Me.refr_task_mn.Size = New System.Drawing.Size(63, 17)
        Me.refr_task_mn.TabIndex = 17
        Me.refr_task_mn.Text = "Refresh"
        Me.refr_task_mn.UseVisualStyleBackColor = True
        '
        'px_bx
        '
        Me.px_bx.Controls.Add(Me.ie_px)
        Me.px_bx.Controls.Add(Me.ie_p_label)
        Me.px_bx.Location = New System.Drawing.Point(14, 263)
        Me.px_bx.Name = "px_bx"
        Me.px_bx.Size = New System.Drawing.Size(267, 100)
        Me.px_bx.TabIndex = 19
        Me.px_bx.TabStop = False
        Me.px_bx.Text = "Proxy"
        Me.px_bx.Visible = False
        '
        'ie_px
        '
        Me.ie_px.FormattingEnabled = True
        Me.ie_px.Location = New System.Drawing.Point(63, 31)
        Me.ie_px.Name = "ie_px"
        Me.ie_px.Size = New System.Drawing.Size(180, 21)
        Me.ie_px.TabIndex = 20
        '
        'ie_p_label
        '
        Me.ie_p_label.AutoSize = True
        Me.ie_p_label.Location = New System.Drawing.Point(6, 34)
        Me.ie_p_label.Name = "ie_p_label"
        Me.ie_p_label.Size = New System.Drawing.Size(48, 13)
        Me.ie_p_label.TabIndex = 20
        Me.ie_p_label.Text = "IE proxy:"
        '
        'power
        '
        Me.power.Controls.Add(Me.pw_refresh)
        Me.power.Controls.Add(Me.pw_option)
        Me.power.Controls.Add(Me.pw_pl)
        Me.power.Location = New System.Drawing.Point(14, 416)
        Me.power.Name = "power"
        Me.power.Size = New System.Drawing.Size(438, 71)
        Me.power.TabIndex = 18
        Me.power.TabStop = False
        Me.power.Text = "Power plan"
        '
        'pw_refresh
        '
        Me.pw_refresh.Location = New System.Drawing.Point(221, 24)
        Me.pw_refresh.Name = "pw_refresh"
        Me.pw_refresh.Size = New System.Drawing.Size(79, 29)
        Me.pw_refresh.TabIndex = 24
        Me.pw_refresh.Text = "Refresh"
        Me.pw_refresh.UseVisualStyleBackColor = True
        '
        'pw_option
        '
        Me.pw_option.Location = New System.Drawing.Point(309, 24)
        Me.pw_option.Name = "pw_option"
        Me.pw_option.Size = New System.Drawing.Size(113, 30)
        Me.pw_option.TabIndex = 1
        Me.pw_option.Text = "Open power options"
        Me.pw_option.UseVisualStyleBackColor = True
        '
        'pw_pl
        '
        Me.pw_pl.FormattingEnabled = True
        Me.pw_pl.Location = New System.Drawing.Point(12, 30)
        Me.pw_pl.Name = "pw_pl"
        Me.pw_pl.Size = New System.Drawing.Size(193, 21)
        Me.pw_pl.TabIndex = 0
        '
        'shutdown
        '
        Me.shutdown.Controls.Add(Me.restart_b)
        Me.shutdown.Controls.Add(Me.Label_sd)
        Me.shutdown.Controls.Add(Me.sd_timer_ck)
        Me.shutdown.Controls.Add(Me.shut_down_count)
        Me.shutdown.Controls.Add(Me.Shut_down_b)
        Me.shutdown.Controls.Add(Me.Log_off_b)
        Me.shutdown.Controls.Add(Me.Hibernate_b)
        Me.shutdown.Controls.Add(Me.Abort_b)
        Me.shutdown.Location = New System.Drawing.Point(14, 517)
        Me.shutdown.Name = "shutdown"
        Me.shutdown.Size = New System.Drawing.Size(445, 138)
        Me.shutdown.TabIndex = 16
        Me.shutdown.TabStop = False
        Me.shutdown.Text = "Shut down controls"
        '
        'restart_b
        '
        Me.restart_b.Location = New System.Drawing.Point(6, 31)
        Me.restart_b.Name = "restart_b"
        Me.restart_b.Size = New System.Drawing.Size(79, 29)
        Me.restart_b.TabIndex = 10
        Me.restart_b.Text = "Restart"
        Me.restart_b.UseVisualStyleBackColor = True
        '
        'Label_sd
        '
        Me.Label_sd.AutoSize = True
        Me.Label_sd.Location = New System.Drawing.Point(285, 100)
        Me.Label_sd.Name = "Label_sd"
        Me.Label_sd.Size = New System.Drawing.Size(27, 13)
        Me.Label_sd.TabIndex = 15
        Me.Label_sd.Text = "sec."
        '
        'sd_timer_ck
        '
        Me.sd_timer_ck.AutoSize = True
        Me.sd_timer_ck.Location = New System.Drawing.Point(6, 100)
        Me.sd_timer_ck.Name = "sd_timer_ck"
        Me.sd_timer_ck.Size = New System.Drawing.Size(192, 17)
        Me.sd_timer_ck.TabIndex = 8
        Me.sd_timer_ck.Text = "Perform the required operation after"
        Me.sd_timer_ck.UseVisualStyleBackColor = True
        '
        'shut_down_count
        '
        Me.shut_down_count.Location = New System.Drawing.Point(198, 98)
        Me.shut_down_count.Name = "shut_down_count"
        Me.shut_down_count.Size = New System.Drawing.Size(81, 20)
        Me.shut_down_count.TabIndex = 14
        '
        'Shut_down_b
        '
        Me.Shut_down_b.Location = New System.Drawing.Point(91, 31)
        Me.Shut_down_b.Name = "Shut_down_b"
        Me.Shut_down_b.Size = New System.Drawing.Size(79, 29)
        Me.Shut_down_b.TabIndex = 9
        Me.Shut_down_b.Text = "Shut down"
        Me.Shut_down_b.UseVisualStyleBackColor = True
        '
        'Log_off_b
        '
        Me.Log_off_b.Location = New System.Drawing.Point(261, 31)
        Me.Log_off_b.Name = "Log_off_b"
        Me.Log_off_b.Size = New System.Drawing.Size(79, 29)
        Me.Log_off_b.TabIndex = 13
        Me.Log_off_b.Text = "Log off"
        Me.Log_off_b.UseVisualStyleBackColor = True
        '
        'Hibernate_b
        '
        Me.Hibernate_b.Location = New System.Drawing.Point(176, 31)
        Me.Hibernate_b.Name = "Hibernate_b"
        Me.Hibernate_b.Size = New System.Drawing.Size(79, 29)
        Me.Hibernate_b.TabIndex = 11
        Me.Hibernate_b.Text = "Hibernate"
        Me.Hibernate_b.UseVisualStyleBackColor = True
        '
        'Abort_b
        '
        Me.Abort_b.Location = New System.Drawing.Point(359, 73)
        Me.Abort_b.Name = "Abort_b"
        Me.Abort_b.Size = New System.Drawing.Size(79, 29)
        Me.Abort_b.TabIndex = 12
        Me.Abort_b.Text = "Abort"
        Me.Abort_b.UseVisualStyleBackColor = True
        '
        'maxb_en
        '
        Me.maxb_en.AutoSize = True
        Me.maxb_en.Location = New System.Drawing.Point(14, 173)
        Me.maxb_en.Name = "maxb_en"
        Me.maxb_en.Size = New System.Drawing.Size(137, 17)
        Me.maxb_en.TabIndex = 7
        Me.maxb_en.Text = "Enable maximize button"
        Me.maxb_en.UseVisualStyleBackColor = True
        '
        'top_most
        '
        Me.top_most.AutoSize = True
        Me.top_most.Location = New System.Drawing.Point(14, 139)
        Me.top_most.Name = "top_most"
        Me.top_most.Size = New System.Drawing.Size(77, 17)
        Me.top_most.TabIndex = 6
        Me.top_most.Text = "Pin to front"
        Me.top_most.UseVisualStyleBackColor = True
        '
        'task_manager
        '
        Me.task_manager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.task_manager.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column7, Me.Column10, Me.Column8, Me.Column9})
        Me.task_manager.Dock = System.Windows.Forms.DockStyle.Right
        Me.task_manager.Location = New System.Drawing.Point(723, 3)
        Me.task_manager.MultiSelect = False
        Me.task_manager.Name = "task_manager"
        Me.task_manager.Size = New System.Drawing.Size(628, 674)
        Me.task_manager.TabIndex = 0
        '
        'Column2
        '
        Me.Column2.HeaderText = "Process name"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 150
        '
        'Column7
        '
        Me.Column7.HeaderText = "Memory usage (MB)"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 130
        '
        'Column10
        '
        Me.Column10.HeaderText = "Working"
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 70
        '
        'Column8
        '
        Me.Column8.HeaderText = "Initialized"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 150
        '
        'Column9
        '
        Me.Column9.HeaderText = "ID"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 60
        '
        'Timer_keep
        '
        Me.Timer_keep.Enabled = True
        Me.Timer_keep.Interval = 1
        '
        'Timer_play
        '
        Me.Timer_play.Interval = 300000
        '
        'Timer_al
        '
        Me.Timer_al.Interval = 10000
        '
        'Timer_refresh
        '
        Me.Timer_refresh.Interval = 60000
        '
        'Timer_al_refresh
        '
        Me.Timer_al_refresh.Enabled = True
        Me.Timer_al_refresh.Interval = 1000
        '
        'File_browse
        '
        Me.File_browse.FileName = "OpenFileDialog1"
        '
        'Timer_browser
        '
        Me.Timer_browser.Interval = 1000
        '
        'Timer_process
        '
        Me.Timer_process.Enabled = True
        Me.Timer_process.Interval = 1000
        '
        'file_save
        '
        Me.file_save.DefaultExt = "html.mht"
        '
        'Timer_sync
        '
        Me.Timer_sync.Interval = 10000
        '
        'Timer_br_refresh
        '
        Me.Timer_br_refresh.Enabled = True
        Me.Timer_br_refresh.Interval = 2000
        '
        'Timer_sd
        '
        Me.Timer_sd.Interval = 10
        '
        'Timer_pw
        '
        Me.Timer_pw.Interval = 1000
        '
        'Timer_fd_size
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1276, 706)
        Me.Controls.Add(Me.TCtrl)
        Me.Name = "Form1"
        Me.Text = "Personal assistant - created by Hiranmoy Basak"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TCtrl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.shortcut.ResumeLayout(False)
        Me.shortcut.PerformLayout()
        Me.alarm.ResumeLayout(False)
        Me.alarm.PerformLayout()
        CType(Me.hour_al, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.min_al, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.task_list, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.sync_sche.ResumeLayout(False)
        Me.sync_sche.PerformLayout()
        CType(Me.hr_sync, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.min_sync, System.ComponentModel.ISupportInitialize).EndInit()
        Me.action_sync_bx.ResumeLayout(False)
        Me.action_sync_bx.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.Menu_browser.ResumeLayout(False)
        Me.Menu_browser.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.Computation_bx.ResumeLayout(False)
        Me.Computation_bx.PerformLayout()
        CType(Me.core_val, System.ComponentModel.ISupportInitialize).EndInit()
        Me.task_mn_box.ResumeLayout(False)
        Me.task_mn_box.PerformLayout()
        Me.px_bx.ResumeLayout(False)
        Me.px_bx.PerformLayout()
        Me.power.ResumeLayout(False)
        Me.shutdown.ResumeLayout(False)
        Me.shutdown.PerformLayout()
        CType(Me.task_manager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TCtrl As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents naming As System.Windows.Forms.Label
    Friend WithEvents task_list As System.Windows.Forms.DataGridView
    Public WithEvents calendar As System.Windows.Forms.MonthCalendar
    Friend WithEvents real_time As System.Windows.Forms.Label
    Friend WithEvents date_pick As System.Windows.Forms.DateTimePicker
    Friend WithEvents save_sche As System.Windows.Forms.Button
    Friend WithEvents alarm As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents t1 As System.Windows.Forms.RadioButton
    Friend WithEvents t3 As System.Windows.Forms.RadioButton
    Friend WithEvents t2 As System.Windows.Forms.RadioButton
    Friend WithEvents test_al As System.Windows.Forms.Button
    Friend WithEvents start_al As System.Windows.Forms.Button
    Friend WithEvents am_pm_al As System.Windows.Forms.ComboBox
    Friend WithEvents min_al As System.Windows.Forms.NumericUpDown
    Friend WithEvents hour_al As System.Windows.Forms.NumericUpDown
    Friend WithEvents Alarm_list As System.Windows.Forms.ListBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Timer_keep As System.Windows.Forms.Timer
    Friend WithEvents loc_f As System.Windows.Forms.Label
    Friend WithEvents shortcuts As System.Windows.Forms.ListBox
    Friend WithEvents add_f As System.Windows.Forms.Button
    Friend WithEvents shortcut As System.Windows.Forms.GroupBox
    Friend WithEvents delete_f As System.Windows.Forms.Button
    Friend WithEvents treDirectory As System.Windows.Forms.TreeView
    Friend WithEvents edit_f As System.Windows.Forms.Button
    Friend WithEvents open_f As System.Windows.Forms.Button
    Friend WithEvents delete_al As System.Windows.Forms.Button
    Friend WithEvents Timer_play As System.Windows.Forms.Timer
    Friend WithEvents Timer_al As System.Windows.Forms.Timer
    Friend WithEvents stop_al As System.Windows.Forms.Button
    Friend WithEvents Timer_refresh As System.Windows.Forms.Timer
    Friend WithEvents delete_pick As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents folder_browse As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents up As System.Windows.Forms.Button
    Friend WithEvents down As System.Windows.Forms.Button
    Friend WithEvents refresh_pick As System.Windows.Forms.Button
    Friend WithEvents Timer_al_refresh As System.Windows.Forms.Timer
    Friend WithEvents browse_al As System.Windows.Forms.Button
    Friend WithEvents music_nm_al As System.Windows.Forms.Label
    Friend WithEvents File_browse As System.Windows.Forms.OpenFileDialog
    Friend WithEvents browse_media_al As System.Windows.Forms.Button
    Friend WithEvents Menu_browser As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseCurrentTabToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseOtherTabsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GoBackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GoForwardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents history As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents AddTabToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseCurrentTabToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Webpage As System.Windows.Forms.TabControl
    Friend WithEvents HistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowHistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RecentlyClosedTabToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RecentPagesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearHistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer_browser As System.Windows.Forms.Timer
    Friend WithEvents task_manager As System.Windows.Forms.DataGridView
    Friend WithEvents end_process As System.Windows.Forms.Button
    Friend WithEvents pro_count As System.Windows.Forms.Label
    Friend WithEvents Timer_process As System.Windows.Forms.Timer
    Friend WithEvents core_val As System.Windows.Forms.NumericUpDown
    Friend WithEvents core_label As System.Windows.Forms.Label
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents file_save As System.Windows.Forms.SaveFileDialog
    Friend WithEvents sync_list As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents remove_sync As System.Windows.Forms.Button
    Friend WithEvents Add_sync As System.Windows.Forms.Button
    Friend WithEvents PrintPreviewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents sync_sche As System.Windows.Forms.GroupBox
    Friend WithEvents hr_sync As System.Windows.Forms.NumericUpDown
    Friend WithEvents min_sync As System.Windows.Forms.NumericUpDown
    Friend WithEvents action_sync_bx As System.Windows.Forms.GroupBox
    Friend WithEvents mrg_des As System.Windows.Forms.RadioButton
    Friend WithEvents ovw_des As System.Windows.Forms.RadioButton
    Friend WithEvents ovw_sr As System.Windows.Forms.RadioButton
    Friend WithEvents am_pm_sync As System.Windows.Forms.ComboBox
    Friend WithEvents label_sync As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents sync_log As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents set_sync As System.Windows.Forms.Button
    Friend WithEvents clr_log As System.Windows.Forms.Button
    Friend WithEvents stop_sync As System.Windows.Forms.Button
    Friend WithEvents Timer_sync As System.Windows.Forms.Timer
    Friend WithEvents Timer_br_refresh As System.Windows.Forms.Timer
    Friend WithEvents ref_ex As System.Windows.Forms.Button
    Friend WithEvents top_most As System.Windows.Forms.CheckBox
    Friend WithEvents maxb_en As System.Windows.Forms.CheckBox
    Friend WithEvents sd_timer_ck As System.Windows.Forms.CheckBox
    Friend WithEvents Timer_sd As System.Windows.Forms.Timer
    Friend WithEvents Abort_b As System.Windows.Forms.Button
    Friend WithEvents Hibernate_b As System.Windows.Forms.Button
    Friend WithEvents restart_b As System.Windows.Forms.Button
    Friend WithEvents Shut_down_b As System.Windows.Forms.Button
    Friend WithEvents Log_off_b As System.Windows.Forms.Button
    Friend WithEvents Label_sd As System.Windows.Forms.Label
    Friend WithEvents shut_down_count As System.Windows.Forms.TextBox
    Friend WithEvents shutdown As System.Windows.Forms.GroupBox
    Friend WithEvents refr_task_mn As System.Windows.Forms.CheckBox
    Friend WithEvents power As System.Windows.Forms.GroupBox
    Friend WithEvents pw_pl As System.Windows.Forms.ComboBox
    Friend WithEvents Timer_pw As System.Windows.Forms.Timer
    Friend WithEvents pw_option As System.Windows.Forms.Button
    Friend WithEvents ie_p_label As System.Windows.Forms.Label
    Friend WithEvents px_bx As System.Windows.Forms.GroupBox
    Friend WithEvents ie_px As System.Windows.Forms.ComboBox
    Friend WithEvents Timer_fd_size As System.Windows.Forms.Timer
    Friend WithEvents end_all_comp As System.Windows.Forms.Button
    Friend WithEvents end_lt_comp As System.Windows.Forms.Button
    Friend WithEvents Computation_bx As System.Windows.Forms.GroupBox
    Friend WithEvents task_mn_box As System.Windows.Forms.GroupBox
    Friend WithEvents all_pro As System.Windows.Forms.CheckBox
    Friend WithEvents mrg_sr As System.Windows.Forms.RadioButton
    Friend WithEvents close_process As System.Windows.Forms.Button
    Friend WithEvents pw_refresh As System.Windows.Forms.Button
    Friend WithEvents restore_task As System.Windows.Forms.Button

End Class
