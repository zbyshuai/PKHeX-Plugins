namespace AutoModPlugins
{
    partial class LiveHeXUI
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
            B_ReadCurrent = new System.Windows.Forms.Button();
            B_WriteCurrent = new System.Windows.Forms.Button();
            checkBox1 = new System.Windows.Forms.CheckBox();
            TB_IP = new System.Windows.Forms.TextBox();
            L_IP = new System.Windows.Forms.Label();
            TB_Port = new System.Windows.Forms.TextBox();
            L_Port = new System.Windows.Forms.Label();
            B_Connect = new System.Windows.Forms.Button();
            B_Disconnect = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            checkBox2 = new System.Windows.Forms.CheckBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            L_ReadOffset = new System.Windows.Forms.Label();
            B_ReadOffset = new System.Windows.Forms.Button();
            L_Slot = new System.Windows.Forms.Label();
            NUD_Slot = new System.Windows.Forms.NumericUpDown();
            L_Box = new System.Windows.Forms.Label();
            NUD_Box = new System.Windows.Forms.NumericUpDown();
            B_ReadSlot = new System.Windows.Forms.Button();
            B_WriteSlot = new System.Windows.Forms.Button();
            groupBox3 = new System.Windows.Forms.GroupBox();
            B_ReadRAM = new System.Windows.Forms.Button();
            RamSize = new System.Windows.Forms.TextBox();
            L_ReadRamSize = new System.Windows.Forms.Label();
            L_ReadRamOffset = new System.Windows.Forms.Label();
            L_USBState = new System.Windows.Forms.Label();
            groupBox4 = new System.Windows.Forms.GroupBox();
            B_ReadPointer = new System.Windows.Forms.Button();
            B_CopyAddress = new System.Windows.Forms.Button();
            B_EditPointer = new System.Windows.Forms.Button();
            L_Pointer = new System.Windows.Forms.Label();
            groupBox5 = new System.Windows.Forms.GroupBox();
            CB_BlockName = new System.Windows.Forms.ComboBox();
            B_EditBlock = new System.Windows.Forms.Button();
            L_Block = new System.Windows.Forms.Label();
            groupBox6 = new System.Windows.Forms.GroupBox();
            RB_Absolute = new System.Windows.Forms.RadioButton();
            RB_Main = new System.Windows.Forms.RadioButton();
            RB_Heap = new System.Windows.Forms.RadioButton();
            L_OffsRelative = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NUD_Slot).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUD_Box).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // B_ReadCurrent
            // 
            B_ReadCurrent.Location = new System.Drawing.Point(15, 70);
            B_ReadCurrent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            B_ReadCurrent.Name = "B_ReadCurrent";
            B_ReadCurrent.Size = new System.Drawing.Size(146, 27);
            B_ReadCurrent.TabIndex = 0;
            B_ReadCurrent.Text = "Read Current Box";
            B_ReadCurrent.UseVisualStyleBackColor = true;
            B_ReadCurrent.Click += B_ReadCurrent_Click;
            // 
            // B_WriteCurrent
            // 
            B_WriteCurrent.Location = new System.Drawing.Point(15, 100);
            B_WriteCurrent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            B_WriteCurrent.Name = "B_WriteCurrent";
            B_WriteCurrent.Size = new System.Drawing.Size(146, 27);
            B_WriteCurrent.TabIndex = 1;
            B_WriteCurrent.Text = "Write Current Box";
            B_WriteCurrent.UseVisualStyleBackColor = true;
            B_WriteCurrent.Click += B_WriteCurrent_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBox1.Location = new System.Drawing.Point(15, 22);
            checkBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(138, 19);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Read On Change Box";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // TB_IP
            // 
            TB_IP.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            TB_IP.Location = new System.Drawing.Point(58, 14);
            TB_IP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TB_IP.Name = "TB_IP";
            TB_IP.Size = new System.Drawing.Size(129, 20);
            TB_IP.TabIndex = 3;
            TB_IP.Text = "111.111.111.111";
            // 
            // L_IP
            // 
            L_IP.Location = new System.Drawing.Point(5, 13);
            L_IP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            L_IP.Name = "L_IP";
            L_IP.Size = new System.Drawing.Size(47, 23);
            L_IP.TabIndex = 4;
            L_IP.Text = "IP:";
            L_IP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TB_Port
            // 
            TB_Port.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            TB_Port.Location = new System.Drawing.Point(58, 44);
            TB_Port.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TB_Port.Name = "TB_Port";
            TB_Port.Size = new System.Drawing.Size(48, 20);
            TB_Port.TabIndex = 5;
            TB_Port.Text = "65535";
            // 
            // L_Port
            // 
            L_Port.Location = new System.Drawing.Point(5, 43);
            L_Port.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            L_Port.Name = "L_Port";
            L_Port.Size = new System.Drawing.Size(47, 23);
            L_Port.TabIndex = 6;
            L_Port.Text = "Port:";
            L_Port.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // B_Connect
            // 
            B_Connect.Location = new System.Drawing.Point(114, 43);
            B_Connect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            B_Connect.Name = "B_Connect";
            B_Connect.Size = new System.Drawing.Size(74, 27);
            B_Connect.TabIndex = 7;
            B_Connect.Text = "Connect";
            B_Connect.UseVisualStyleBackColor = true;
            B_Connect.Click += B_Connect_Click;
            // 
            // B_Disconnect
            // 
            B_Disconnect.Location = new System.Drawing.Point(114, 43);
            B_Disconnect.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            B_Disconnect.Name = "B_Disconnect";
            B_Disconnect.Size = new System.Drawing.Size(74, 27);
            B_Disconnect.TabIndex = 15;
            B_Disconnect.Text = "Disconnect";
            B_Disconnect.UseVisualStyleBackColor = true;
            B_Disconnect.Visible = false;
            B_Disconnect.Click += B_Disconnect_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(B_ReadCurrent);
            groupBox1.Controls.Add(B_WriteCurrent);
            groupBox1.Enabled = false;
            groupBox1.Location = new System.Drawing.Point(14, 76);
            groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Size = new System.Drawing.Size(174, 134);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Boxes";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Checked = true;
            checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBox2.Location = new System.Drawing.Point(15, 44);
            checkBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new System.Drawing.Size(91, 19);
            checkBox2.TabIndex = 3;
            checkBox2.Text = "Inject In Slot";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(L_ReadOffset);
            groupBox2.Controls.Add(B_ReadOffset);
            groupBox2.Controls.Add(L_Slot);
            groupBox2.Controls.Add(NUD_Slot);
            groupBox2.Controls.Add(L_Box);
            groupBox2.Controls.Add(NUD_Box);
            groupBox2.Controls.Add(B_ReadSlot);
            groupBox2.Controls.Add(B_WriteSlot);
            groupBox2.Enabled = false;
            groupBox2.Location = new System.Drawing.Point(200, 14);
            groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox2.Size = new System.Drawing.Size(174, 196);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "PKM Editor";
            // 
            // L_ReadOffset
            // 
            L_ReadOffset.Location = new System.Drawing.Point(20, 163);
            L_ReadOffset.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            L_ReadOffset.Name = "L_ReadOffset";
            L_ReadOffset.Size = new System.Drawing.Size(49, 23);
            L_ReadOffset.TabIndex = 15;
            L_ReadOffset.Text = "Offset:";
            L_ReadOffset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // B_ReadOffset
            // 
            B_ReadOffset.Location = new System.Drawing.Point(15, 133);
            B_ReadOffset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            B_ReadOffset.Name = "B_ReadOffset";
            B_ReadOffset.Size = new System.Drawing.Size(146, 27);
            B_ReadOffset.TabIndex = 13;
            B_ReadOffset.Text = "Read from Offset";
            B_ReadOffset.UseVisualStyleBackColor = true;
            B_ReadOffset.Click += B_ReadOffset_Click;
            // 
            // L_Slot
            // 
            L_Slot.Location = new System.Drawing.Point(31, 102);
            L_Slot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            L_Slot.Name = "L_Slot";
            L_Slot.Size = new System.Drawing.Size(49, 23);
            L_Slot.TabIndex = 12;
            L_Slot.Text = "Slot:";
            L_Slot.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NUD_Slot
            // 
            NUD_Slot.Location = new System.Drawing.Point(88, 104);
            NUD_Slot.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            NUD_Slot.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            NUD_Slot.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NUD_Slot.Name = "NUD_Slot";
            NUD_Slot.Size = new System.Drawing.Size(44, 23);
            NUD_Slot.TabIndex = 11;
            NUD_Slot.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // L_Box
            // 
            L_Box.Location = new System.Drawing.Point(31, 77);
            L_Box.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            L_Box.Name = "L_Box";
            L_Box.Size = new System.Drawing.Size(49, 23);
            L_Box.TabIndex = 10;
            L_Box.Text = "Box:";
            L_Box.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NUD_Box
            // 
            NUD_Box.Location = new System.Drawing.Point(88, 80);
            NUD_Box.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            NUD_Box.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            NUD_Box.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NUD_Box.Name = "NUD_Box";
            NUD_Box.Size = new System.Drawing.Size(44, 23);
            NUD_Box.TabIndex = 2;
            NUD_Box.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // B_ReadSlot
            // 
            B_ReadSlot.Location = new System.Drawing.Point(15, 21);
            B_ReadSlot.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            B_ReadSlot.Name = "B_ReadSlot";
            B_ReadSlot.Size = new System.Drawing.Size(146, 27);
            B_ReadSlot.TabIndex = 0;
            B_ReadSlot.Text = "Read from Slot";
            B_ReadSlot.UseVisualStyleBackColor = true;
            B_ReadSlot.Click += B_ReadSlot_Click;
            // 
            // B_WriteSlot
            // 
            B_WriteSlot.Location = new System.Drawing.Point(15, 51);
            B_WriteSlot.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            B_WriteSlot.Name = "B_WriteSlot";
            B_WriteSlot.Size = new System.Drawing.Size(146, 27);
            B_WriteSlot.TabIndex = 1;
            B_WriteSlot.Text = "Write to Slot";
            B_WriteSlot.UseVisualStyleBackColor = true;
            B_WriteSlot.Click += B_WriteSlot_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(B_ReadRAM);
            groupBox3.Controls.Add(RamSize);
            groupBox3.Controls.Add(L_ReadRamSize);
            groupBox3.Controls.Add(L_ReadRamOffset);
            groupBox3.Enabled = false;
            groupBox3.Location = new System.Drawing.Point(14, 217);
            groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox3.Size = new System.Drawing.Size(358, 55);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "RAM Editor";
            // 
            // B_ReadRAM
            // 
            B_ReadRAM.Location = new System.Drawing.Point(262, 20);
            B_ReadRAM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            B_ReadRAM.Name = "B_ReadRAM";
            B_ReadRAM.Size = new System.Drawing.Size(84, 27);
            B_ReadRAM.TabIndex = 21;
            B_ReadRAM.Text = "Edit RAM";
            B_ReadRAM.UseVisualStyleBackColor = true;
            B_ReadRAM.Click += B_ReadRAM_Click;
            // 
            // RamSize
            // 
            RamSize.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            RamSize.Location = new System.Drawing.Point(192, 21);
            RamSize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            RamSize.MaxLength = 8;
            RamSize.Name = "RamSize";
            RamSize.Size = new System.Drawing.Size(63, 20);
            RamSize.TabIndex = 20;
            RamSize.Text = "344";
            // 
            // L_ReadRamSize
            // 
            L_ReadRamSize.Location = new System.Drawing.Point(149, 20);
            L_ReadRamSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            L_ReadRamSize.Name = "L_ReadRamSize";
            L_ReadRamSize.Size = new System.Drawing.Size(42, 23);
            L_ReadRamSize.TabIndex = 19;
            L_ReadRamSize.Text = "Size:";
            L_ReadRamSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // L_ReadRamOffset
            // 
            L_ReadRamOffset.Location = new System.Drawing.Point(12, 20);
            L_ReadRamOffset.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            L_ReadRamOffset.Name = "L_ReadRamOffset";
            L_ReadRamOffset.Size = new System.Drawing.Size(49, 23);
            L_ReadRamOffset.TabIndex = 17;
            L_ReadRamOffset.Text = "Offset:";
            L_ReadRamOffset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // L_USBState
            // 
            L_USBState.AutoSize = true;
            L_USBState.Location = new System.Drawing.Point(18, 17);
            L_USBState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            L_USBState.Name = "L_USBState";
            L_USBState.Size = new System.Drawing.Size(109, 15);
            L_USBState.TabIndex = 11;
            L_USBState.Text = "USB-Botbase Mode";
            L_USBState.Visible = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(B_ReadPointer);
            groupBox4.Controls.Add(B_CopyAddress);
            groupBox4.Controls.Add(B_EditPointer);
            groupBox4.Controls.Add(L_Pointer);
            groupBox4.Enabled = false;
            groupBox4.Location = new System.Drawing.Point(14, 279);
            groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox4.Size = new System.Drawing.Size(358, 84);
            groupBox4.TabIndex = 12;
            groupBox4.TabStop = false;
            groupBox4.Text = "Pointer Lookup";
            // 
            // B_ReadPointer
            // 
            B_ReadPointer.Location = new System.Drawing.Point(238, 50);
            B_ReadPointer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            B_ReadPointer.Name = "B_ReadPointer";
            B_ReadPointer.Size = new System.Drawing.Size(110, 27);
            B_ReadPointer.TabIndex = 23;
            B_ReadPointer.Text = "Read Pointer";
            B_ReadPointer.UseVisualStyleBackColor = true;
            B_ReadPointer.Click += B_ReadPointer_Click;
            // 
            // B_CopyAddress
            // 
            B_CopyAddress.Location = new System.Drawing.Point(10, 50);
            B_CopyAddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            B_CopyAddress.Name = "B_CopyAddress";
            B_CopyAddress.Size = new System.Drawing.Size(110, 27);
            B_CopyAddress.TabIndex = 22;
            B_CopyAddress.Text = "Copy Address";
            B_CopyAddress.UseVisualStyleBackColor = true;
            B_CopyAddress.Click += B_CopyAddress_Click;
            // 
            // B_EditPointer
            // 
            B_EditPointer.Location = new System.Drawing.Point(125, 50);
            B_EditPointer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            B_EditPointer.Name = "B_EditPointer";
            B_EditPointer.Size = new System.Drawing.Size(110, 27);
            B_EditPointer.TabIndex = 21;
            B_EditPointer.Text = "Edit RAM";
            B_EditPointer.UseVisualStyleBackColor = true;
            B_EditPointer.Click += B_EditPointerData_Click;
            // 
            // L_Pointer
            // 
            L_Pointer.Location = new System.Drawing.Point(4, 18);
            L_Pointer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            L_Pointer.Name = "L_Pointer";
            L_Pointer.Size = new System.Drawing.Size(57, 23);
            L_Pointer.TabIndex = 17;
            L_Pointer.Text = "Pointer:";
            L_Pointer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(CB_BlockName);
            groupBox5.Controls.Add(B_EditBlock);
            groupBox5.Controls.Add(L_Block);
            groupBox5.Enabled = false;
            groupBox5.Location = new System.Drawing.Point(14, 436);
            groupBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox5.Size = new System.Drawing.Size(358, 55);
            groupBox5.TabIndex = 13;
            groupBox5.TabStop = false;
            groupBox5.Text = "Block Editor";
            // 
            // CB_BlockName
            // 
            CB_BlockName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CB_BlockName.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            CB_BlockName.Location = new System.Drawing.Point(68, 22);
            CB_BlockName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            CB_BlockName.Name = "CB_BlockName";
            CB_BlockName.Size = new System.Drawing.Size(188, 22);
            CB_BlockName.Sorted = true;
            CB_BlockName.TabIndex = 22;
            // 
            // B_EditBlock
            // 
            B_EditBlock.Location = new System.Drawing.Point(262, 21);
            B_EditBlock.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            B_EditBlock.Name = "B_EditBlock";
            B_EditBlock.Size = new System.Drawing.Size(84, 28);
            B_EditBlock.TabIndex = 21;
            B_EditBlock.Text = "Edit Block";
            B_EditBlock.UseVisualStyleBackColor = true;
            B_EditBlock.Click += B_EditBlock_Click;
            // 
            // L_Block
            // 
            L_Block.Location = new System.Drawing.Point(12, 21);
            L_Block.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            L_Block.Name = "L_Block";
            L_Block.Size = new System.Drawing.Size(49, 23);
            L_Block.TabIndex = 17;
            L_Block.Text = "Block:";
            L_Block.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(RB_Absolute);
            groupBox6.Controls.Add(RB_Main);
            groupBox6.Controls.Add(RB_Heap);
            groupBox6.Controls.Add(L_OffsRelative);
            groupBox6.Enabled = false;
            groupBox6.Location = new System.Drawing.Point(14, 372);
            groupBox6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox6.Size = new System.Drawing.Size(359, 58);
            groupBox6.TabIndex = 14;
            groupBox6.TabStop = false;
            groupBox6.Text = "RAM Config";
            // 
            // RB_Absolute
            // 
            RB_Absolute.AutoSize = true;
            RB_Absolute.Location = new System.Drawing.Point(278, 23);
            RB_Absolute.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            RB_Absolute.Name = "RB_Absolute";
            RB_Absolute.Size = new System.Drawing.Size(72, 19);
            RB_Absolute.TabIndex = 3;
            RB_Absolute.Text = "Absolute";
            RB_Absolute.UseVisualStyleBackColor = true;
            // 
            // RB_Main
            // 
            RB_Main.AutoSize = true;
            RB_Main.Location = new System.Drawing.Point(220, 23);
            RB_Main.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            RB_Main.Name = "RB_Main";
            RB_Main.Size = new System.Drawing.Size(52, 19);
            RB_Main.TabIndex = 2;
            RB_Main.Text = "Main";
            RB_Main.UseVisualStyleBackColor = true;
            // 
            // RB_Heap
            // 
            RB_Heap.AutoSize = true;
            RB_Heap.Checked = true;
            RB_Heap.Location = new System.Drawing.Point(160, 23);
            RB_Heap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            RB_Heap.Name = "RB_Heap";
            RB_Heap.Size = new System.Drawing.Size(53, 19);
            RB_Heap.TabIndex = 1;
            RB_Heap.TabStop = true;
            RB_Heap.Text = "Heap";
            RB_Heap.UseVisualStyleBackColor = true;
            // 
            // L_OffsRelative
            // 
            L_OffsRelative.AutoSize = true;
            L_OffsRelative.Location = new System.Drawing.Point(15, 24);
            L_OffsRelative.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            L_OffsRelative.Name = "L_OffsRelative";
            L_OffsRelative.Size = new System.Drawing.Size(129, 15);
            L_OffsRelative.TabIndex = 0;
            L_OffsRelative.Text = "RAM offsets relative to:";
            // 
            // LiveHeXUI
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(386, 502);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(B_Connect);
            Controls.Add(B_Disconnect);
            Controls.Add(L_Port);
            Controls.Add(TB_Port);
            Controls.Add(L_IP);
            Controls.Add(TB_IP);
            Controls.Add(L_USBState);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LiveHeXUI";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "LiveHeXUI";
            FormClosing += LiveHeXUI_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)NUD_Slot).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUD_Box).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button B_ReadCurrent;
        private System.Windows.Forms.Button B_WriteCurrent;
        private System.Windows.Forms.CheckBox CB_ReadBox;
        private System.Windows.Forms.TextBox TB_IP;
        private System.Windows.Forms.Label L_IP;
        private System.Windows.Forms.TextBox TB_Port;
        private System.Windows.Forms.Label L_Port;
        private System.Windows.Forms.Button B_Connect;
        private System.Windows.Forms.Button B_Disconnect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button B_ReadSlot;
        private System.Windows.Forms.Button B_WriteSlot;
        private System.Windows.Forms.Label L_Slot;
        private System.Windows.Forms.NumericUpDown NUD_Slot;
        private System.Windows.Forms.Label L_Box;
        private System.Windows.Forms.NumericUpDown NUD_Box;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label L_ReadOffset;
        private System.Windows.Forms.Button B_ReadOffset;
        private HexTextBox TB_Offset;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button B_ReadRAM;
        private System.Windows.Forms.TextBox RamSize;
        private System.Windows.Forms.Label L_ReadRamSize;
        private HexTextBox RamOffset;
        private System.Windows.Forms.Label L_ReadRamOffset;
        private System.Windows.Forms.Label L_USBState;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button B_EditPointer;
        private HexTextBox TB_Pointer;
        private System.Windows.Forms.Label L_Pointer;
        private System.Windows.Forms.Button B_CopyAddress;
        private System.Windows.Forms.Button B_ReadPointer;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox CB_BlockName;
        private System.Windows.Forms.Button B_EditBlock;
        private System.Windows.Forms.Label L_Block;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton RB_Absolute;
        private System.Windows.Forms.RadioButton RB_Main;
        private System.Windows.Forms.RadioButton RB_Heap;
        private System.Windows.Forms.Label L_OffsRelative;
    }
}