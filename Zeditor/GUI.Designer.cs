namespace Zeditor
{
    partial class GUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            StateBox = new System.Windows.Forms.ListBox();
            MenuStrip = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            openESDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saveESDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exportESDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            editESDPropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saveEditorContentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            stateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            addNewStateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cloneStateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            deleteStateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cloneToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            searchPrecedingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            editStateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            bulkTargetSwitchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            noHelpForYouToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            testEntryScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            AddStateBtn = new System.Windows.Forms.Button();
            DeleteStateBtn = new System.Windows.Forms.Button();
            CloneStateBtn = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            TargetStateBox = new System.Windows.Forms.TextBox();
            GoTargetBtn = new System.Windows.Forms.Button();
            ConditionTree = new System.Windows.Forms.TreeView();
            AddConditionBtn = new System.Windows.Forms.Button();
            DeleteConditionBtn = new System.Windows.Forms.Button();
            MoveCndUpBtn = new System.Windows.Forms.Button();
            MoveCndDownBtn = new System.Windows.Forms.Button();
            AddSubconditionBtn = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            CloneCndBtn = new System.Windows.Forms.Button();
            AddSiblingConditionBtn = new System.Windows.Forms.Button();
            TargetStateNameBox = new System.Windows.Forms.TextBox();
            RenameConditionBtn = new System.Windows.Forms.Button();
            EditorTitleBox = new System.Windows.Forms.TextBox();
            RevertBtn = new System.Windows.Forms.Button();
            saveLabel = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            editorControl = new System.Windows.Forms.TabControl();
            stateTab = new System.Windows.Forms.TabPage();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            groupBox5 = new System.Windows.Forms.GroupBox();
            EntryCmdBox = new FastColoredTextBoxNS.FastColoredTextBox();
            groupBox6 = new System.Windows.Forms.GroupBox();
            ExitCmdBox = new FastColoredTextBoxNS.FastColoredTextBox();
            groupBox7 = new System.Windows.Forms.GroupBox();
            WhileCmdBox = new FastColoredTextBoxNS.FastColoredTextBox();
            conditionTab = new System.Windows.Forms.TabPage();
            flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            groupBox3 = new System.Windows.Forms.GroupBox();
            EvaluatorBox = new FastColoredTextBoxNS.FastColoredTextBox();
            groupBox4 = new System.Windows.Forms.GroupBox();
            PassCmdBox = new FastColoredTextBoxNS.FastColoredTextBox();
            AddGroupBtn = new System.Windows.Forms.Button();
            DeleteGroupBtn = new System.Windows.Forms.Button();
            CloneGroupBtn = new System.Windows.Forms.Button();
            editStateBtn = new System.Windows.Forms.Button();
            RenameGroupBtn = new System.Windows.Forms.Button();
            StateGroupBox = new System.Windows.Forms.ComboBox();
            stateGroupLayoutBox = new System.Windows.Forms.GroupBox();
            groupBox8 = new System.Windows.Forms.GroupBox();
            LongFormatBox = new System.Windows.Forms.CheckBox();
            MenuStrip.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            editorControl.SuspendLayout();
            stateTab.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EntryCmdBox).BeginInit();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ExitCmdBox).BeginInit();
            groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)WhileCmdBox).BeginInit();
            conditionTab.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EvaluatorBox).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PassCmdBox).BeginInit();
            stateGroupLayoutBox.SuspendLayout();
            groupBox8.SuspendLayout();
            SuspendLayout();
            // 
            // StateBox
            // 
            StateBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            StateBox.DisplayMember = "Name";
            StateBox.FormattingEnabled = true;
            StateBox.HorizontalScrollbar = true;
            StateBox.Location = new System.Drawing.Point(7, 20);
            StateBox.Margin = new System.Windows.Forms.Padding(2);
            StateBox.Name = "StateBox";
            StateBox.Size = new System.Drawing.Size(291, 424);
            StateBox.TabIndex = 1;
            StateBox.SelectedIndexChanged += StateBox_SelectedIndexChanged;
            // 
            // MenuStrip
            // 
            MenuStrip.BackColor = System.Drawing.SystemColors.ControlLightLight;
            MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, stateToolStripMenuItem, toolsToolStripMenuItem, helpToolStripMenuItem });
            MenuStrip.Location = new System.Drawing.Point(0, 0);
            MenuStrip.Name = "MenuStrip";
            MenuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            MenuStrip.Size = new System.Drawing.Size(1164, 24);
            MenuStrip.TabIndex = 2;
            MenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { openESDToolStripMenuItem, saveESDToolStripMenuItem, exportESDToolStripMenuItem, quitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openESDToolStripMenuItem
            // 
            openESDToolStripMenuItem.Name = "openESDToolStripMenuItem";
            openESDToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O;
            openESDToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            openESDToolStripMenuItem.Text = "Open ESD";
            openESDToolStripMenuItem.Click += openESDToolStripMenuItem_Click;
            // 
            // saveESDToolStripMenuItem
            // 
            saveESDToolStripMenuItem.Name = "saveESDToolStripMenuItem";
            saveESDToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S;
            saveESDToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            saveESDToolStripMenuItem.Text = "Save ESD";
            saveESDToolStripMenuItem.Click += saveESDToolStripMenuItem_Click_1;
            // 
            // exportESDToolStripMenuItem
            // 
            exportESDToolStripMenuItem.Name = "exportESDToolStripMenuItem";
            exportESDToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.S;
            exportESDToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            exportESDToolStripMenuItem.Text = "Export ESD";
            exportESDToolStripMenuItem.Click += exportESDToolStripMenuItem_Click;
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { editESDPropertiesToolStripMenuItem, saveEditorContentToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // editESDPropertiesToolStripMenuItem
            // 
            editESDPropertiesToolStripMenuItem.Name = "editESDPropertiesToolStripMenuItem";
            editESDPropertiesToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.P;
            editESDPropertiesToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            editESDPropertiesToolStripMenuItem.Text = "Edit ESD Properties";
            editESDPropertiesToolStripMenuItem.Click += editESDPropertiesToolStripMenuItem_Click;
            // 
            // saveEditorContentToolStripMenuItem
            // 
            saveEditorContentToolStripMenuItem.Name = "saveEditorContentToolStripMenuItem";
            saveEditorContentToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S;
            saveEditorContentToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            saveEditorContentToolStripMenuItem.Text = "Save Editor Content";
            saveEditorContentToolStripMenuItem.Visible = false;
            saveEditorContentToolStripMenuItem.Click += saveEditorContentToolStripMenuItem_Click;
            // 
            // stateToolStripMenuItem
            // 
            stateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { addNewStateToolStripMenuItem, cloneStateToolStripMenuItem, deleteStateToolStripMenuItem, cloneToToolStripMenuItem, searchPrecedingToolStripMenuItem, editStateToolStripMenuItem });
            stateToolStripMenuItem.Name = "stateToolStripMenuItem";
            stateToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            stateToolStripMenuItem.Text = "States";
            // 
            // addNewStateToolStripMenuItem
            // 
            addNewStateToolStripMenuItem.Name = "addNewStateToolStripMenuItem";
            addNewStateToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N;
            addNewStateToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            addNewStateToolStripMenuItem.Text = "Add New State";
            addNewStateToolStripMenuItem.Click += addNewStateToolStripMenuItem_Click;
            // 
            // cloneStateToolStripMenuItem
            // 
            cloneStateToolStripMenuItem.Name = "cloneStateToolStripMenuItem";
            cloneStateToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Shift+N";
            cloneStateToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            cloneStateToolStripMenuItem.Text = "Clone State";
            cloneStateToolStripMenuItem.Click += cloneStateToolStripMenuItem_Click;
            // 
            // deleteStateToolStripMenuItem
            // 
            deleteStateToolStripMenuItem.Name = "deleteStateToolStripMenuItem";
            deleteStateToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Shift+D";
            deleteStateToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            deleteStateToolStripMenuItem.Text = "Delete State";
            deleteStateToolStripMenuItem.Click += deleteStateToolStripMenuItem_Click;
            // 
            // cloneToToolStripMenuItem
            // 
            cloneToToolStripMenuItem.Name = "cloneToToolStripMenuItem";
            cloneToToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            cloneToToolStripMenuItem.Text = "Clone State To";
            cloneToToolStripMenuItem.Click += cloneToToolStripMenuItem_Click;
            // 
            // searchPrecedingToolStripMenuItem
            // 
            searchPrecedingToolStripMenuItem.Name = "searchPrecedingToolStripMenuItem";
            searchPrecedingToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            searchPrecedingToolStripMenuItem.Text = "Search Preceding";
            searchPrecedingToolStripMenuItem.Click += searchPrecedingToolStripMenuItem_Click;
            // 
            // editStateToolStripMenuItem
            // 
            editStateToolStripMenuItem.Name = "editStateToolStripMenuItem";
            editStateToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            editStateToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            editStateToolStripMenuItem.Text = "Edit State";
            editStateToolStripMenuItem.Click += RenameStateBtn_Click;
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { bulkTargetSwitchToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            toolsToolStripMenuItem.Text = "Tools";
            // 
            // bulkTargetSwitchToolStripMenuItem
            // 
            bulkTargetSwitchToolStripMenuItem.Name = "bulkTargetSwitchToolStripMenuItem";
            bulkTargetSwitchToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            bulkTargetSwitchToolStripMenuItem.Text = "Bulk Target Switch";
            bulkTargetSwitchToolStripMenuItem.Click += bulkTargetSwitchToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { noHelpForYouToolStripMenuItem, testEntryScriptToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // noHelpForYouToolStripMenuItem
            // 
            noHelpForYouToolStripMenuItem.Name = "noHelpForYouToolStripMenuItem";
            noHelpForYouToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            noHelpForYouToolStripMenuItem.Text = "About";
            noHelpForYouToolStripMenuItem.Click += noHelpForYouToolStripMenuItem_Click;
            // 
            // testEntryScriptToolStripMenuItem
            // 
            testEntryScriptToolStripMenuItem.Name = "testEntryScriptToolStripMenuItem";
            testEntryScriptToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            testEntryScriptToolStripMenuItem.Text = "Test Entry Script";
            testEntryScriptToolStripMenuItem.Visible = false;
            testEntryScriptToolStripMenuItem.Click += testEntryScriptToolStripMenuItem_Click;
            // 
            // AddStateBtn
            // 
            AddStateBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            AddStateBtn.Location = new System.Drawing.Point(9, 457);
            AddStateBtn.Margin = new System.Windows.Forms.Padding(2);
            AddStateBtn.Name = "AddStateBtn";
            AddStateBtn.Size = new System.Drawing.Size(57, 27);
            AddStateBtn.TabIndex = 12;
            AddStateBtn.Text = "Add";
            AddStateBtn.UseVisualStyleBackColor = true;
            AddStateBtn.Click += addNewStateToolStripMenuItem_Click;
            // 
            // DeleteStateBtn
            // 
            DeleteStateBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            DeleteStateBtn.Location = new System.Drawing.Point(209, 457);
            DeleteStateBtn.Margin = new System.Windows.Forms.Padding(2);
            DeleteStateBtn.Name = "DeleteStateBtn";
            DeleteStateBtn.Size = new System.Drawing.Size(84, 27);
            DeleteStateBtn.TabIndex = 13;
            DeleteStateBtn.Text = "Delete";
            DeleteStateBtn.UseVisualStyleBackColor = true;
            DeleteStateBtn.Click += deleteStateToolStripMenuItem_Click;
            // 
            // CloneStateBtn
            // 
            CloneStateBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            CloneStateBtn.Location = new System.Drawing.Point(68, 457);
            CloneStateBtn.Margin = new System.Windows.Forms.Padding(2);
            CloneStateBtn.Name = "CloneStateBtn";
            CloneStateBtn.Size = new System.Drawing.Size(61, 27);
            CloneStateBtn.TabIndex = 14;
            CloneStateBtn.Text = "Clone";
            CloneStateBtn.UseVisualStyleBackColor = true;
            CloneStateBtn.Click += cloneStateToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(215, 418);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(68, 15);
            label1.TabIndex = 6;
            label1.Text = "Target State";
            // 
            // TargetStateBox
            // 
            TargetStateBox.Location = new System.Drawing.Point(295, 413);
            TargetStateBox.Margin = new System.Windows.Forms.Padding(2);
            TargetStateBox.Name = "TargetStateBox";
            TargetStateBox.Size = new System.Drawing.Size(44, 23);
            TargetStateBox.TabIndex = 5;
            TargetStateBox.TextChanged += TargetStateBox_TextChanged;
            TargetStateBox.KeyDown += TargetStateBox_KeyDown;
            TargetStateBox.Leave += TargetStateBox_Leave;
            // 
            // GoTargetBtn
            // 
            GoTargetBtn.Location = new System.Drawing.Point(218, 466);
            GoTargetBtn.Margin = new System.Windows.Forms.Padding(2);
            GoTargetBtn.Name = "GoTargetBtn";
            GoTargetBtn.Size = new System.Drawing.Size(121, 32);
            GoTargetBtn.TabIndex = 7;
            GoTargetBtn.TabStop = false;
            GoTargetBtn.Text = "Go to Target";
            GoTargetBtn.UseVisualStyleBackColor = true;
            GoTargetBtn.Click += GoTargetBtn_Click;
            // 
            // ConditionTree
            // 
            ConditionTree.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            ConditionTree.HideSelection = false;
            ConditionTree.Location = new System.Drawing.Point(5, 20);
            ConditionTree.Margin = new System.Windows.Forms.Padding(2);
            ConditionTree.Name = "ConditionTree";
            ConditionTree.PathSeparator = "-";
            ConditionTree.Size = new System.Drawing.Size(202, 665);
            ConditionTree.TabIndex = 3;
            ConditionTree.AfterSelect += ConditionTree_AfterSelect;
            // 
            // AddConditionBtn
            // 
            AddConditionBtn.Location = new System.Drawing.Point(218, 61);
            AddConditionBtn.Margin = new System.Windows.Forms.Padding(2);
            AddConditionBtn.Name = "AddConditionBtn";
            AddConditionBtn.Size = new System.Drawing.Size(121, 30);
            AddConditionBtn.TabIndex = 9;
            AddConditionBtn.TabStop = false;
            AddConditionBtn.Text = "New Primary CND";
            AddConditionBtn.UseVisualStyleBackColor = true;
            AddConditionBtn.Click += AddConditionBtn_Click;
            // 
            // DeleteConditionBtn
            // 
            DeleteConditionBtn.Location = new System.Drawing.Point(218, 240);
            DeleteConditionBtn.Margin = new System.Windows.Forms.Padding(2);
            DeleteConditionBtn.Name = "DeleteConditionBtn";
            DeleteConditionBtn.Size = new System.Drawing.Size(121, 30);
            DeleteConditionBtn.TabIndex = 10;
            DeleteConditionBtn.TabStop = false;
            DeleteConditionBtn.Text = "Delete Condition";
            DeleteConditionBtn.UseVisualStyleBackColor = true;
            DeleteConditionBtn.Click += DeleteConditionBtn_Click;
            // 
            // MoveCndUpBtn
            // 
            MoveCndUpBtn.Location = new System.Drawing.Point(218, 329);
            MoveCndUpBtn.Margin = new System.Windows.Forms.Padding(2);
            MoveCndUpBtn.Name = "MoveCndUpBtn";
            MoveCndUpBtn.Size = new System.Drawing.Size(65, 30);
            MoveCndUpBtn.TabIndex = 10;
            MoveCndUpBtn.TabStop = false;
            MoveCndUpBtn.Text = "Move ↑";
            MoveCndUpBtn.UseVisualStyleBackColor = true;
            MoveCndUpBtn.Click += MoveCndUpBtn_Click;
            // 
            // MoveCndDownBtn
            // 
            MoveCndDownBtn.Location = new System.Drawing.Point(218, 363);
            MoveCndDownBtn.Margin = new System.Windows.Forms.Padding(2);
            MoveCndDownBtn.Name = "MoveCndDownBtn";
            MoveCndDownBtn.Size = new System.Drawing.Size(65, 30);
            MoveCndDownBtn.TabIndex = 11;
            MoveCndDownBtn.TabStop = false;
            MoveCndDownBtn.Text = "Move ↓";
            MoveCndDownBtn.UseVisualStyleBackColor = true;
            MoveCndDownBtn.Click += MoveCndDownBtn_Click;
            // 
            // AddSubconditionBtn
            // 
            AddSubconditionBtn.Location = new System.Drawing.Point(218, 96);
            AddSubconditionBtn.Margin = new System.Windows.Forms.Padding(2);
            AddSubconditionBtn.Name = "AddSubconditionBtn";
            AddSubconditionBtn.Size = new System.Drawing.Size(121, 30);
            AddSubconditionBtn.TabIndex = 12;
            AddSubconditionBtn.TabStop = false;
            AddSubconditionBtn.Text = "New Child CND";
            AddSubconditionBtn.UseVisualStyleBackColor = true;
            AddSubconditionBtn.Click += AddSubconditionBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            groupBox1.Controls.Add(CloneCndBtn);
            groupBox1.Controls.Add(AddSiblingConditionBtn);
            groupBox1.Controls.Add(TargetStateNameBox);
            groupBox1.Controls.Add(RenameConditionBtn);
            groupBox1.Controls.Add(AddSubconditionBtn);
            groupBox1.Controls.Add(MoveCndDownBtn);
            groupBox1.Controls.Add(MoveCndUpBtn);
            groupBox1.Controls.Add(DeleteConditionBtn);
            groupBox1.Controls.Add(AddConditionBtn);
            groupBox1.Controls.Add(ConditionTree);
            groupBox1.Controls.Add(GoTargetBtn);
            groupBox1.Controls.Add(TargetStateBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new System.Drawing.Point(317, 29);
            groupBox1.Margin = new System.Windows.Forms.Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(2);
            groupBox1.Size = new System.Drawing.Size(348, 690);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Conditions";
            // 
            // CloneCndBtn
            // 
            CloneCndBtn.Location = new System.Drawing.Point(218, 174);
            CloneCndBtn.Margin = new System.Windows.Forms.Padding(2);
            CloneCndBtn.Name = "CloneCndBtn";
            CloneCndBtn.Size = new System.Drawing.Size(121, 30);
            CloneCndBtn.TabIndex = 16;
            CloneCndBtn.TabStop = false;
            CloneCndBtn.Text = "Deep Clone CND";
            CloneCndBtn.UseVisualStyleBackColor = true;
            CloneCndBtn.Click += CloneCndBtn_Click;
            // 
            // AddSiblingConditionBtn
            // 
            AddSiblingConditionBtn.Location = new System.Drawing.Point(218, 130);
            AddSiblingConditionBtn.Margin = new System.Windows.Forms.Padding(2);
            AddSiblingConditionBtn.Name = "AddSiblingConditionBtn";
            AddSiblingConditionBtn.Size = new System.Drawing.Size(121, 40);
            AddSiblingConditionBtn.TabIndex = 15;
            AddSiblingConditionBtn.TabStop = false;
            AddSiblingConditionBtn.Text = "New Linked Pre-Sibling CND";
            AddSiblingConditionBtn.UseVisualStyleBackColor = true;
            AddSiblingConditionBtn.Click += AddSiblingConditionBtn_Click;
            // 
            // TargetStateNameBox
            // 
            TargetStateNameBox.Location = new System.Drawing.Point(218, 440);
            TargetStateNameBox.Margin = new System.Windows.Forms.Padding(2);
            TargetStateNameBox.Name = "TargetStateNameBox";
            TargetStateNameBox.ReadOnly = true;
            TargetStateNameBox.Size = new System.Drawing.Size(121, 23);
            TargetStateNameBox.TabIndex = 14;
            TargetStateNameBox.TabStop = false;
            // 
            // RenameConditionBtn
            // 
            RenameConditionBtn.Location = new System.Drawing.Point(218, 274);
            RenameConditionBtn.Margin = new System.Windows.Forms.Padding(2);
            RenameConditionBtn.Name = "RenameConditionBtn";
            RenameConditionBtn.Size = new System.Drawing.Size(121, 30);
            RenameConditionBtn.TabIndex = 13;
            RenameConditionBtn.TabStop = false;
            RenameConditionBtn.Text = "Rename Condition";
            RenameConditionBtn.UseVisualStyleBackColor = true;
            RenameConditionBtn.Click += RenameConditionBtn_Click;
            // 
            // EditorTitleBox
            // 
            EditorTitleBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            EditorTitleBox.Location = new System.Drawing.Point(9, 23);
            EditorTitleBox.Margin = new System.Windows.Forms.Padding(2);
            EditorTitleBox.Name = "EditorTitleBox";
            EditorTitleBox.ReadOnly = true;
            EditorTitleBox.Size = new System.Drawing.Size(327, 23);
            EditorTitleBox.TabIndex = 9;
            EditorTitleBox.TabStop = false;
            // 
            // RevertBtn
            // 
            RevertBtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            RevertBtn.Location = new System.Drawing.Point(341, 20);
            RevertBtn.Margin = new System.Windows.Forms.Padding(2);
            RevertBtn.Name = "RevertBtn";
            RevertBtn.Size = new System.Drawing.Size(131, 28);
            RevertBtn.TabIndex = 11;
            RevertBtn.Text = "Revert to Saved";
            RevertBtn.UseVisualStyleBackColor = true;
            RevertBtn.Click += RevertBtn_Click;
            // 
            // saveLabel
            // 
            saveLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            saveLabel.Location = new System.Drawing.Point(208, 61);
            saveLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            saveLabel.Name = "saveLabel";
            saveLabel.Size = new System.Drawing.Size(243, 15);
            saveLabel.TabIndex = 12;
            saveLabel.Text = "ESD SAVED";
            saveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            saveLabel.Visible = false;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            groupBox2.Controls.Add(saveLabel);
            groupBox2.Controls.Add(RevertBtn);
            groupBox2.Controls.Add(EditorTitleBox);
            groupBox2.Controls.Add(editorControl);
            groupBox2.Location = new System.Drawing.Point(674, 29);
            groupBox2.Margin = new System.Windows.Forms.Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(2);
            groupBox2.Size = new System.Drawing.Size(479, 690);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Editor";
            // 
            // editorControl
            // 
            editorControl.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            editorControl.Controls.Add(stateTab);
            editorControl.Controls.Add(conditionTab);
            editorControl.Location = new System.Drawing.Point(2, 61);
            editorControl.Margin = new System.Windows.Forms.Padding(2);
            editorControl.Name = "editorControl";
            editorControl.SelectedIndex = 0;
            editorControl.Size = new System.Drawing.Size(475, 627);
            editorControl.TabIndex = 0;
            editorControl.SelectedIndexChanged += editorControl_SelectedIndexChanged;
            // 
            // stateTab
            // 
            stateTab.Controls.Add(flowLayoutPanel1);
            stateTab.Location = new System.Drawing.Point(4, 24);
            stateTab.Margin = new System.Windows.Forms.Padding(2);
            stateTab.Name = "stateTab";
            stateTab.Padding = new System.Windows.Forms.Padding(2);
            stateTab.Size = new System.Drawing.Size(467, 599);
            stateTab.TabIndex = 0;
            stateTab.Text = "State";
            stateTab.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(groupBox5);
            flowLayoutPanel1.Controls.Add(groupBox6);
            flowLayoutPanel1.Controls.Add(groupBox7);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(463, 595);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(EntryCmdBox);
            groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox5.Location = new System.Drawing.Point(2, 2);
            groupBox5.Margin = new System.Windows.Forms.Padding(2);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new System.Windows.Forms.Padding(2);
            groupBox5.Size = new System.Drawing.Size(450, 147);
            groupBox5.TabIndex = 7;
            groupBox5.TabStop = false;
            groupBox5.Text = "Entry Commands";
            // 
            // EntryCmdBox
            // 
            EntryCmdBox.AccessibleDescription = "Textbox control";
            EntryCmdBox.AccessibleName = "Fast Colored Text Box";
            EntryCmdBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            EntryCmdBox.AutoCompleteBracketsList = new char[]
    {
    '(',
    ')',
    '{',
    '}',
    '[',
    ']',
    '"',
    '"',
    '\'',
    '\''
    };
            EntryCmdBox.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*(?<range>:)\\s*(?<range>[^;]+);";
            EntryCmdBox.AutoScrollMinSize = new System.Drawing.Size(0, 14);
            EntryCmdBox.BackBrush = null;
            EntryCmdBox.CharCnWidth = 12;
            EntryCmdBox.CharHeight = 14;
            EntryCmdBox.CharWidth = 7;
            EntryCmdBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            EntryCmdBox.DefaultMarkerSize = 8;
            EntryCmdBox.DisabledColor = System.Drawing.Color.FromArgb(100, 180, 180, 180);
            EntryCmdBox.Dock = System.Windows.Forms.DockStyle.Fill;
            EntryCmdBox.FindForm = null;
            EntryCmdBox.FoldingHighlightColor = System.Drawing.Color.LightGray;
            EntryCmdBox.FoldingHighlightEnabled = false;
            EntryCmdBox.Font = new System.Drawing.Font("Consolas", 9F);
            EntryCmdBox.GoToForm = null;
            EntryCmdBox.Hotkeys = resources.GetString("EntryCmdBox.Hotkeys");
            EntryCmdBox.IsReplaceMode = false;
            EntryCmdBox.Location = new System.Drawing.Point(2, 18);
            EntryCmdBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            EntryCmdBox.Name = "EntryCmdBox";
            EntryCmdBox.Paddings = new System.Windows.Forms.Padding(0);
            EntryCmdBox.ReplaceForm = null;
            EntryCmdBox.SelectionColor = System.Drawing.Color.FromArgb(60, 0, 0, 255);
            EntryCmdBox.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("EntryCmdBox.ServiceColors");
            EntryCmdBox.Size = new System.Drawing.Size(446, 127);
            EntryCmdBox.TabIndex = 0;
            EntryCmdBox.ToolTipDelay = 100;
            EntryCmdBox.UseCJK = FastColoredTextBoxNS.CJKMode.Disabled;
            EntryCmdBox.WordWrap = true;
            EntryCmdBox.Zoom = 100;
            EntryCmdBox.TextChanged += EntryCmdBox_TextChanged;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(ExitCmdBox);
            groupBox6.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox6.Location = new System.Drawing.Point(2, 153);
            groupBox6.Margin = new System.Windows.Forms.Padding(2);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new System.Windows.Forms.Padding(2);
            groupBox6.Size = new System.Drawing.Size(450, 147);
            groupBox6.TabIndex = 10;
            groupBox6.TabStop = false;
            groupBox6.Text = "Exit Commands";
            // 
            // ExitCmdBox
            // 
            ExitCmdBox.AccessibleDescription = "Textbox control";
            ExitCmdBox.AccessibleName = "Fast Colored Text Box";
            ExitCmdBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            ExitCmdBox.AutoCompleteBracketsList = new char[]
    {
    '(',
    ')',
    '{',
    '}',
    '[',
    ']',
    '"',
    '"',
    '\'',
    '\''
    };
            ExitCmdBox.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*(?<range>:)\\s*(?<range>[^;]+);";
            ExitCmdBox.AutoScrollMinSize = new System.Drawing.Size(0, 14);
            ExitCmdBox.BackBrush = null;
            ExitCmdBox.CharCnWidth = 12;
            ExitCmdBox.CharHeight = 14;
            ExitCmdBox.CharWidth = 7;
            ExitCmdBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            ExitCmdBox.DefaultMarkerSize = 8;
            ExitCmdBox.DisabledColor = System.Drawing.Color.FromArgb(100, 180, 180, 180);
            ExitCmdBox.Dock = System.Windows.Forms.DockStyle.Fill;
            ExitCmdBox.FindForm = null;
            ExitCmdBox.FoldingHighlightColor = System.Drawing.Color.LightGray;
            ExitCmdBox.FoldingHighlightEnabled = false;
            ExitCmdBox.Font = new System.Drawing.Font("Consolas", 9F);
            ExitCmdBox.GoToForm = null;
            ExitCmdBox.Hotkeys = resources.GetString("ExitCmdBox.Hotkeys");
            ExitCmdBox.IsReplaceMode = false;
            ExitCmdBox.Location = new System.Drawing.Point(2, 18);
            ExitCmdBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ExitCmdBox.Name = "ExitCmdBox";
            ExitCmdBox.Paddings = new System.Windows.Forms.Padding(0);
            ExitCmdBox.ReplaceForm = null;
            ExitCmdBox.SelectionColor = System.Drawing.Color.FromArgb(60, 0, 0, 255);
            ExitCmdBox.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("ExitCmdBox.ServiceColors");
            ExitCmdBox.Size = new System.Drawing.Size(446, 127);
            ExitCmdBox.TabIndex = 1;
            ExitCmdBox.ToolTipDelay = 100;
            ExitCmdBox.UseCJK = FastColoredTextBoxNS.CJKMode.Hanzi;
            ExitCmdBox.WordWrap = true;
            ExitCmdBox.Zoom = 100;
            ExitCmdBox.TextChanged += ExitCmdBox_TextChanged;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(WhileCmdBox);
            groupBox7.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox7.Location = new System.Drawing.Point(2, 304);
            groupBox7.Margin = new System.Windows.Forms.Padding(2);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new System.Windows.Forms.Padding(2);
            groupBox7.Size = new System.Drawing.Size(450, 147);
            groupBox7.TabIndex = 11;
            groupBox7.TabStop = false;
            groupBox7.Text = "While Commands";
            // 
            // WhileCmdBox
            // 
            WhileCmdBox.AccessibleDescription = "Textbox control";
            WhileCmdBox.AccessibleName = "Fast Colored Text Box";
            WhileCmdBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            WhileCmdBox.AutoCompleteBracketsList = new char[]
    {
    '(',
    ')',
    '{',
    '}',
    '[',
    ']',
    '"',
    '"',
    '\'',
    '\''
    };
            WhileCmdBox.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*(?<range>:)\\s*(?<range>[^;]+);";
            WhileCmdBox.AutoScrollMinSize = new System.Drawing.Size(0, 14);
            WhileCmdBox.BackBrush = null;
            WhileCmdBox.CharCnWidth = 12;
            WhileCmdBox.CharHeight = 14;
            WhileCmdBox.CharWidth = 7;
            WhileCmdBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            WhileCmdBox.DefaultMarkerSize = 8;
            WhileCmdBox.DisabledColor = System.Drawing.Color.FromArgb(100, 180, 180, 180);
            WhileCmdBox.Dock = System.Windows.Forms.DockStyle.Fill;
            WhileCmdBox.FindForm = null;
            WhileCmdBox.FoldingHighlightColor = System.Drawing.Color.LightGray;
            WhileCmdBox.FoldingHighlightEnabled = false;
            WhileCmdBox.Font = new System.Drawing.Font("Consolas", 9F);
            WhileCmdBox.GoToForm = null;
            WhileCmdBox.Hotkeys = resources.GetString("WhileCmdBox.Hotkeys");
            WhileCmdBox.IsReplaceMode = false;
            WhileCmdBox.Location = new System.Drawing.Point(2, 18);
            WhileCmdBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            WhileCmdBox.Name = "WhileCmdBox";
            WhileCmdBox.Paddings = new System.Windows.Forms.Padding(0);
            WhileCmdBox.ReplaceForm = null;
            WhileCmdBox.SelectionColor = System.Drawing.Color.FromArgb(60, 0, 0, 255);
            WhileCmdBox.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("WhileCmdBox.ServiceColors");
            WhileCmdBox.Size = new System.Drawing.Size(446, 127);
            WhileCmdBox.TabIndex = 2;
            WhileCmdBox.ToolTipDelay = 100;
            WhileCmdBox.UseCJK = FastColoredTextBoxNS.CJKMode.Hanzi;
            WhileCmdBox.WordWrap = true;
            WhileCmdBox.Zoom = 100;
            WhileCmdBox.TextChanged += WhileCmdBox_TextChanged;
            // 
            // conditionTab
            // 
            conditionTab.Controls.Add(flowLayoutPanel3);
            conditionTab.Location = new System.Drawing.Point(4, 24);
            conditionTab.Margin = new System.Windows.Forms.Padding(2);
            conditionTab.Name = "conditionTab";
            conditionTab.Size = new System.Drawing.Size(467, 599);
            conditionTab.TabIndex = 3;
            conditionTab.Text = "Condition";
            conditionTab.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(groupBox3);
            flowLayoutPanel3.Controls.Add(groupBox4);
            flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new System.Drawing.Size(467, 599);
            flowLayoutPanel3.TabIndex = 2;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(EvaluatorBox);
            groupBox3.Location = new System.Drawing.Point(2, 2);
            groupBox3.Margin = new System.Windows.Forms.Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new System.Windows.Forms.Padding(2);
            groupBox3.Size = new System.Drawing.Size(350, 282);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Evaluator";
            // 
            // EvaluatorBox
            // 
            EvaluatorBox.AccessibleDescription = "Textbox control";
            EvaluatorBox.AccessibleName = "Fast Colored Text Box";
            EvaluatorBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            EvaluatorBox.AutoCompleteBracketsList = new char[]
    {
    '(',
    ')',
    '{',
    '}',
    '[',
    ']',
    '"',
    '"',
    '\'',
    '\''
    };
            EvaluatorBox.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*(?<range>:)\\s*(?<range>[^;]+);";
            EvaluatorBox.AutoScrollMinSize = new System.Drawing.Size(0, 14);
            EvaluatorBox.BackBrush = null;
            EvaluatorBox.CharCnWidth = 12;
            EvaluatorBox.CharHeight = 14;
            EvaluatorBox.CharWidth = 7;
            EvaluatorBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            EvaluatorBox.DefaultMarkerSize = 8;
            EvaluatorBox.DisabledColor = System.Drawing.Color.FromArgb(100, 180, 180, 180);
            EvaluatorBox.Dock = System.Windows.Forms.DockStyle.Fill;
            EvaluatorBox.FindForm = null;
            EvaluatorBox.FoldingHighlightColor = System.Drawing.Color.LightGray;
            EvaluatorBox.FoldingHighlightEnabled = false;
            EvaluatorBox.Font = new System.Drawing.Font("Consolas", 9F);
            EvaluatorBox.GoToForm = null;
            EvaluatorBox.Hotkeys = resources.GetString("EvaluatorBox.Hotkeys");
            EvaluatorBox.IsReplaceMode = false;
            EvaluatorBox.Location = new System.Drawing.Point(2, 18);
            EvaluatorBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            EvaluatorBox.Name = "EvaluatorBox";
            EvaluatorBox.Paddings = new System.Windows.Forms.Padding(0);
            EvaluatorBox.ReplaceForm = null;
            EvaluatorBox.SelectionColor = System.Drawing.Color.FromArgb(60, 0, 0, 255);
            EvaluatorBox.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("EvaluatorBox.ServiceColors");
            EvaluatorBox.Size = new System.Drawing.Size(346, 262);
            EvaluatorBox.TabIndex = 2;
            EvaluatorBox.ToolTipDelay = 100;
            EvaluatorBox.UseCJK = FastColoredTextBoxNS.CJKMode.Hanzi;
            EvaluatorBox.WordWrap = true;
            EvaluatorBox.Zoom = 100;
            EvaluatorBox.TextChanged += EvaluatorBox_TextChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(PassCmdBox);
            groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            groupBox4.Location = new System.Drawing.Point(2, 288);
            groupBox4.Margin = new System.Windows.Forms.Padding(2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new System.Windows.Forms.Padding(2);
            groupBox4.Size = new System.Drawing.Size(350, 282);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Pass Commands";
            // 
            // PassCmdBox
            // 
            PassCmdBox.AccessibleDescription = "Textbox control";
            PassCmdBox.AccessibleName = "Fast Colored Text Box";
            PassCmdBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            PassCmdBox.AutoCompleteBracketsList = new char[]
    {
    '(',
    ')',
    '{',
    '}',
    '[',
    ']',
    '"',
    '"',
    '\'',
    '\''
    };
            PassCmdBox.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*(?<range>:)\\s*(?<range>[^;]+);";
            PassCmdBox.AutoScrollMinSize = new System.Drawing.Size(0, 14);
            PassCmdBox.BackBrush = null;
            PassCmdBox.CharCnWidth = 12;
            PassCmdBox.CharHeight = 14;
            PassCmdBox.CharWidth = 7;
            PassCmdBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            PassCmdBox.DefaultMarkerSize = 8;
            PassCmdBox.DisabledColor = System.Drawing.Color.FromArgb(100, 180, 180, 180);
            PassCmdBox.Dock = System.Windows.Forms.DockStyle.Fill;
            PassCmdBox.FindForm = null;
            PassCmdBox.FoldingHighlightColor = System.Drawing.Color.LightGray;
            PassCmdBox.FoldingHighlightEnabled = false;
            PassCmdBox.Font = new System.Drawing.Font("Consolas", 9F);
            PassCmdBox.GoToForm = null;
            PassCmdBox.Hotkeys = resources.GetString("PassCmdBox.Hotkeys");
            PassCmdBox.IsReplaceMode = false;
            PassCmdBox.Location = new System.Drawing.Point(2, 18);
            PassCmdBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            PassCmdBox.Name = "PassCmdBox";
            PassCmdBox.Paddings = new System.Windows.Forms.Padding(0);
            PassCmdBox.ReplaceForm = null;
            PassCmdBox.SelectionColor = System.Drawing.Color.FromArgb(60, 0, 0, 255);
            PassCmdBox.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("PassCmdBox.ServiceColors");
            PassCmdBox.Size = new System.Drawing.Size(346, 262);
            PassCmdBox.TabIndex = 2;
            PassCmdBox.ToolTipDelay = 100;
            PassCmdBox.UseCJK = FastColoredTextBoxNS.CJKMode.Hanzi;
            PassCmdBox.WordWrap = true;
            PassCmdBox.Zoom = 100;
            // 
            // AddGroupBtn
            // 
            AddGroupBtn.Location = new System.Drawing.Point(5, 69);
            AddGroupBtn.Margin = new System.Windows.Forms.Padding(2);
            AddGroupBtn.Name = "AddGroupBtn";
            AddGroupBtn.Size = new System.Drawing.Size(61, 27);
            AddGroupBtn.TabIndex = 15;
            AddGroupBtn.Text = "Add";
            AddGroupBtn.UseVisualStyleBackColor = true;
            AddGroupBtn.Click += AddGroupBtn_Click;
            // 
            // DeleteGroupBtn
            // 
            DeleteGroupBtn.Location = new System.Drawing.Point(236, 69);
            DeleteGroupBtn.Margin = new System.Windows.Forms.Padding(2);
            DeleteGroupBtn.Name = "DeleteGroupBtn";
            DeleteGroupBtn.Size = new System.Drawing.Size(59, 27);
            DeleteGroupBtn.TabIndex = 16;
            DeleteGroupBtn.Text = "Delete";
            DeleteGroupBtn.UseVisualStyleBackColor = true;
            DeleteGroupBtn.Click += DeleteGroupBtn_Click;
            // 
            // CloneGroupBtn
            // 
            CloneGroupBtn.Location = new System.Drawing.Point(72, 69);
            CloneGroupBtn.Margin = new System.Windows.Forms.Padding(2);
            CloneGroupBtn.Name = "CloneGroupBtn";
            CloneGroupBtn.Size = new System.Drawing.Size(55, 27);
            CloneGroupBtn.TabIndex = 17;
            CloneGroupBtn.Text = "Clone";
            CloneGroupBtn.UseVisualStyleBackColor = true;
            CloneGroupBtn.Click += CloneGroupBtn_Click;
            // 
            // editStateBtn
            // 
            editStateBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            editStateBtn.Location = new System.Drawing.Point(131, 457);
            editStateBtn.Margin = new System.Windows.Forms.Padding(2);
            editStateBtn.Name = "editStateBtn";
            editStateBtn.Size = new System.Drawing.Size(76, 27);
            editStateBtn.TabIndex = 18;
            editStateBtn.Text = "Edit";
            editStateBtn.UseVisualStyleBackColor = true;
            editStateBtn.Click += RenameStateBtn_Click;
            // 
            // RenameGroupBtn
            // 
            RenameGroupBtn.Location = new System.Drawing.Point(132, 69);
            RenameGroupBtn.Margin = new System.Windows.Forms.Padding(2);
            RenameGroupBtn.Name = "RenameGroupBtn";
            RenameGroupBtn.Size = new System.Drawing.Size(99, 27);
            RenameGroupBtn.TabIndex = 19;
            RenameGroupBtn.Text = "Rename";
            RenameGroupBtn.UseVisualStyleBackColor = true;
            RenameGroupBtn.Click += RenameGroupBtn_Click;
            // 
            // StateGroupBox
            // 
            StateGroupBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            StateGroupBox.FormattingEnabled = true;
            StateGroupBox.Location = new System.Drawing.Point(5, 30);
            StateGroupBox.Margin = new System.Windows.Forms.Padding(2);
            StateGroupBox.Name = "StateGroupBox";
            StateGroupBox.Size = new System.Drawing.Size(291, 23);
            StateGroupBox.TabIndex = 21;
            StateGroupBox.SelectedIndexChanged += StateGroupBox_SelectedIndexChanged;
            // 
            // stateGroupLayoutBox
            // 
            stateGroupLayoutBox.Controls.Add(DeleteGroupBtn);
            stateGroupLayoutBox.Controls.Add(CloneGroupBtn);
            stateGroupLayoutBox.Controls.Add(AddGroupBtn);
            stateGroupLayoutBox.Controls.Add(RenameGroupBtn);
            stateGroupLayoutBox.Controls.Add(StateGroupBox);
            stateGroupLayoutBox.Location = new System.Drawing.Point(5, 98);
            stateGroupLayoutBox.Margin = new System.Windows.Forms.Padding(2);
            stateGroupLayoutBox.Name = "stateGroupLayoutBox";
            stateGroupLayoutBox.Padding = new System.Windows.Forms.Padding(2);
            stateGroupLayoutBox.Size = new System.Drawing.Size(308, 110);
            stateGroupLayoutBox.TabIndex = 22;
            stateGroupLayoutBox.TabStop = false;
            stateGroupLayoutBox.Text = "State Groups";
            // 
            // groupBox8
            // 
            groupBox8.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            groupBox8.Controls.Add(StateBox);
            groupBox8.Controls.Add(editStateBtn);
            groupBox8.Controls.Add(AddStateBtn);
            groupBox8.Controls.Add(CloneStateBtn);
            groupBox8.Controls.Add(DeleteStateBtn);
            groupBox8.Location = new System.Drawing.Point(5, 216);
            groupBox8.Margin = new System.Windows.Forms.Padding(2);
            groupBox8.Name = "groupBox8";
            groupBox8.Padding = new System.Windows.Forms.Padding(2);
            groupBox8.Size = new System.Drawing.Size(308, 497);
            groupBox8.TabIndex = 19;
            groupBox8.TabStop = false;
            groupBox8.Text = "States";
            // 
            // LongFormatBox
            // 
            LongFormatBox.AutoSize = true;
            LongFormatBox.Location = new System.Drawing.Point(31, 52);
            LongFormatBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            LongFormatBox.Name = "LongFormatBox";
            LongFormatBox.Size = new System.Drawing.Size(235, 19);
            LongFormatBox.TabIndex = 23;
            LongFormatBox.Text = "Save in 64-bit mode (uncheck for PTDE)";
            LongFormatBox.UseVisualStyleBackColor = true;
            LongFormatBox.CheckedChanged += LongFormatBox_CheckedChanged;
            // 
            // GUI
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1164, 733);
            Controls.Add(LongFormatBox);
            Controls.Add(stateGroupLayoutBox);
            Controls.Add(groupBox8);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(MenuStrip);
            KeyPreview = true;
            MainMenuStrip = MenuStrip;
            Margin = new System.Windows.Forms.Padding(2);
            MinimumSize = new System.Drawing.Size(1173, 722);
            Name = "GUI";
            Text = "Zeditor";
            FormClosing += GUI_FormClosing;
            Load += GUI_Load;
            KeyDown += GUI_KeyDown;
            Resize += GUI_Resize;
            MenuStrip.ResumeLayout(false);
            MenuStrip.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            editorControl.ResumeLayout(false);
            stateTab.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)EntryCmdBox).EndInit();
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ExitCmdBox).EndInit();
            groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)WhileCmdBox).EndInit();
            conditionTab.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)EvaluatorBox).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PassCmdBox).EndInit();
            stateGroupLayoutBox.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox StateBox;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openESDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportESDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewStateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cloneStateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteStateToolStripMenuItem;
        private System.Windows.Forms.Button AddStateBtn;
        private System.Windows.Forms.Button DeleteStateBtn;
        private System.Windows.Forms.Button CloneStateBtn;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveEditorContentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noHelpForYouToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TargetStateBox;
        private System.Windows.Forms.Button GoTargetBtn;
        private System.Windows.Forms.TreeView ConditionTree;
        private System.Windows.Forms.Button AddConditionBtn;
        private System.Windows.Forms.Button DeleteConditionBtn;
        private System.Windows.Forms.Button MoveCndUpBtn;
        private System.Windows.Forms.Button MoveCndDownBtn;
        private System.Windows.Forms.Button AddSubconditionBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox EditorTitleBox;
        private System.Windows.Forms.Button RevertBtn;
        private System.Windows.Forms.Label saveLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button AddGroupBtn;
        private System.Windows.Forms.Button DeleteGroupBtn;
        private System.Windows.Forms.Button CloneGroupBtn;
        private System.Windows.Forms.ToolStripMenuItem editESDPropertiesToolStripMenuItem;
        private System.Windows.Forms.TabControl editorControl;
        private System.Windows.Forms.TabPage stateTab;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TabPage conditionTab;
        private System.Windows.Forms.Button RenameConditionBtn;
        private System.Windows.Forms.Button editStateBtn;
        private System.Windows.Forms.ToolStripMenuItem saveESDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Button RenameGroupBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.TextBox TargetStateNameBox;
        private System.Windows.Forms.ComboBox StateGroupBox;
        private System.Windows.Forms.GroupBox stateGroupLayoutBox;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button AddSiblingConditionBtn;
        private System.Windows.Forms.CheckBox LongFormatBox;
        private FastColoredTextBoxNS.FastColoredTextBox EntryCmdBox;
        private FastColoredTextBoxNS.FastColoredTextBox ExitCmdBox;
        private FastColoredTextBoxNS.FastColoredTextBox WhileCmdBox;
        private FastColoredTextBoxNS.FastColoredTextBox EvaluatorBox;
        private FastColoredTextBoxNS.FastColoredTextBox PassCmdBox;
        private System.Windows.Forms.ToolStripMenuItem testEntryScriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cloneToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchPrecedingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bulkTargetSwitchToolStripMenuItem;
        private System.Windows.Forms.Button CloneCndBtn;
        private System.Windows.Forms.ToolStripMenuItem editStateToolStripMenuItem;
    }
}

