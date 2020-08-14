namespace Base64Tools
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ToBase64_GB = new System.Windows.Forms.GroupBox();
            this.cbAutoLineBreak = new System.Windows.Forms.CheckBox();
            this.lblContentLength = new System.Windows.Forms.Label();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.imageListAction = new System.Windows.Forms.ImageList(this.components);
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblContent = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.gbBase64ToFile = new System.Windows.Forms.GroupBox();
            this.lbSigTypesCount = new System.Windows.Forms.Label();
            this.cbSigTypes = new System.Windows.Forms.ComboBox();
            this.lblSigTypes = new System.Windows.Forms.Label();
            this.lblBase64Content = new System.Windows.Forms.Label();
            this.cbAutoConvert = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbExtensions = new System.Windows.Forms.ComboBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.txtBase64Info = new System.Windows.Forms.TextBox();
            this.lblBase64Info = new System.Windows.Forms.Label();
            this.btnBase64Convert = new System.Windows.Forms.Button();
            this.btnPaste = new System.Windows.Forms.Button();
            this.lblBase64_2 = new System.Windows.Forms.Label();
            this.txtBase64Content = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tslblPoweredBy = new System.Windows.Forms.ToolStripStatusLabel();
            this.sp1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslblRecords = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.bsSigTypes = new System.Windows.Forms.BindingSource(this.components);
            this.ToBase64_GB.SuspendLayout();
            this.gbBase64ToFile.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSigTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // ToBase64_GB
            // 
            this.ToBase64_GB.Controls.Add(this.cbAutoLineBreak);
            this.ToBase64_GB.Controls.Add(this.lblContentLength);
            this.ToBase64_GB.Controls.Add(this.txtInfo);
            this.ToBase64_GB.Controls.Add(this.lblInfo);
            this.ToBase64_GB.Controls.Add(this.btnCopy);
            this.ToBase64_GB.Controls.Add(this.btnConvert);
            this.ToBase64_GB.Controls.Add(this.lblContent);
            this.ToBase64_GB.Controls.Add(this.txtContent);
            this.ToBase64_GB.Controls.Add(this.btnBrowse);
            this.ToBase64_GB.Controls.Add(this.txtAddress);
            this.ToBase64_GB.Controls.Add(this.lblAddress);
            this.ToBase64_GB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ToBase64_GB.Location = new System.Drawing.Point(12, 12);
            this.ToBase64_GB.Name = "ToBase64_GB";
            this.ToBase64_GB.Size = new System.Drawing.Size(607, 255);
            this.ToBase64_GB.TabIndex = 0;
            this.ToBase64_GB.TabStop = false;
            this.ToBase64_GB.Text = "File to Base64";
            // 
            // cbAutoLineBreak
            // 
            this.cbAutoLineBreak.AutoSize = true;
            this.cbAutoLineBreak.Location = new System.Drawing.Point(202, 222);
            this.cbAutoLineBreak.Name = "cbAutoLineBreak";
            this.cbAutoLineBreak.Size = new System.Drawing.Size(217, 17);
            this.cbAutoLineBreak.TabIndex = 57;
            this.cbAutoLineBreak.Text = "Auto Insert Line-Breaks (Every 76 Chars)";
            this.cbAutoLineBreak.UseVisualStyleBackColor = true;
            // 
            // lblContentLength
            // 
            this.lblContentLength.AutoSize = true;
            this.lblContentLength.ForeColor = System.Drawing.Color.Sienna;
            this.lblContentLength.Location = new System.Drawing.Point(63, 214);
            this.lblContentLength.Name = "lblContentLength";
            this.lblContentLength.Size = new System.Drawing.Size(52, 13);
            this.lblContentLength.TabIndex = 49;
            this.lblContentLength.Text = "Length: 0";
            // 
            // txtInfo
            // 
            this.txtInfo.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtInfo.Location = new System.Drawing.Point(63, 61);
            this.txtInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInfo.MaxLength = 50;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(409, 20);
            this.txtInfo.TabIndex = 48;
            this.txtInfo.TabStop = false;
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfo.AutoSize = true;
            this.lblInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblInfo.Location = new System.Drawing.Point(6, 66);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(50, 13);
            this.lblInfo.TabIndex = 47;
            this.lblInfo.Text = "File Info :";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCopy
            // 
            this.btnCopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCopy.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCopy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCopy.ImageKey = "067.png";
            this.btnCopy.ImageList = this.imageListAction;
            this.btnCopy.Location = new System.Drawing.Point(421, 217);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(173, 25);
            this.btnCopy.TabIndex = 46;
            this.btnCopy.Text = "Copy To Clipboard";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // imageListAction
            // 
            this.imageListAction.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListAction.ImageStream")));
            this.imageListAction.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListAction.Images.SetKeyName(0, "add.png");
            this.imageListAction.Images.SetKeyName(1, "cancel.png");
            this.imageListAction.Images.SetKeyName(2, "caution.png");
            this.imageListAction.Images.SetKeyName(3, "edit.png");
            this.imageListAction.Images.SetKeyName(4, "error.png");
            this.imageListAction.Images.SetKeyName(5, "ok.png");
            this.imageListAction.Images.SetKeyName(6, "remove.png");
            this.imageListAction.Images.SetKeyName(7, "save.png");
            this.imageListAction.Images.SetKeyName(8, "save2.png");
            this.imageListAction.Images.SetKeyName(9, "search.png");
            this.imageListAction.Images.SetKeyName(10, "reset.png");
            this.imageListAction.Images.SetKeyName(11, "auto.png");
            this.imageListAction.Images.SetKeyName(12, "067.png");
            this.imageListAction.Images.SetKeyName(13, "068.png");
            this.imageListAction.Images.SetKeyName(14, "090.png");
            // 
            // btnConvert
            // 
            this.btnConvert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConvert.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnConvert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConvert.ImageIndex = 11;
            this.btnConvert.ImageList = this.imageListAction;
            this.btnConvert.Location = new System.Drawing.Point(483, 58);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(111, 25);
            this.btnConvert.TabIndex = 45;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblContent
            // 
            this.lblContent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblContent.AutoSize = true;
            this.lblContent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblContent.Location = new System.Drawing.Point(6, 101);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(49, 13);
            this.lblContent.TabIndex = 43;
            this.lblContent.Text = "Base64 :";
            this.lblContent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtContent
            // 
            this.txtContent.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.Location = new System.Drawing.Point(63, 101);
            this.txtContent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContent.MaxLength = 0;
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ReadOnly = true;
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContent.Size = new System.Drawing.Size(531, 109);
            this.txtContent.TabIndex = 42;
            this.txtContent.TextChanged += new System.EventHandler(this.txtContent_TextChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBrowse.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowse.ImageIndex = 9;
            this.btnBrowse.ImageList = this.imageListAction;
            this.btnBrowse.Location = new System.Drawing.Point(483, 19);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(111, 25);
            this.btnBrowse.TabIndex = 41;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtAddress.Location = new System.Drawing.Point(63, 22);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress.MaxLength = 50;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(409, 20);
            this.txtAddress.TabIndex = 28;
            this.txtAddress.TabStop = false;
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddress.AutoSize = true;
            this.lblAddress.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAddress.Location = new System.Drawing.Point(6, 25);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(51, 13);
            this.lblAddress.TabIndex = 25;
            this.lblAddress.Text = "Address :";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbBase64ToFile
            // 
            this.gbBase64ToFile.Controls.Add(this.lbSigTypesCount);
            this.gbBase64ToFile.Controls.Add(this.cbSigTypes);
            this.gbBase64ToFile.Controls.Add(this.lblSigTypes);
            this.gbBase64ToFile.Controls.Add(this.lblBase64Content);
            this.gbBase64ToFile.Controls.Add(this.cbAutoConvert);
            this.gbBase64ToFile.Controls.Add(this.label1);
            this.gbBase64ToFile.Controls.Add(this.cbExtensions);
            this.gbBase64ToFile.Controls.Add(this.btnPreview);
            this.gbBase64ToFile.Controls.Add(this.btnSaveAs);
            this.gbBase64ToFile.Controls.Add(this.txtBase64Info);
            this.gbBase64ToFile.Controls.Add(this.lblBase64Info);
            this.gbBase64ToFile.Controls.Add(this.btnBase64Convert);
            this.gbBase64ToFile.Controls.Add(this.btnPaste);
            this.gbBase64ToFile.Controls.Add(this.lblBase64_2);
            this.gbBase64ToFile.Controls.Add(this.txtBase64Content);
            this.gbBase64ToFile.Location = new System.Drawing.Point(12, 285);
            this.gbBase64ToFile.Name = "gbBase64ToFile";
            this.gbBase64ToFile.Size = new System.Drawing.Size(607, 326);
            this.gbBase64ToFile.TabIndex = 12;
            this.gbBase64ToFile.TabStop = false;
            this.gbBase64ToFile.Text = "Base64 to File";
            // 
            // lbSigTypesCount
            // 
            this.lbSigTypesCount.AutoSize = true;
            this.lbSigTypesCount.ForeColor = System.Drawing.Color.Sienna;
            this.lbSigTypesCount.Location = new System.Drawing.Point(514, 252);
            this.lbSigTypesCount.Name = "lbSigTypesCount";
            this.lbSigTypesCount.Size = new System.Drawing.Size(74, 13);
            this.lbSigTypesCount.TabIndex = 60;
            this.lbSigTypesCount.Text = "Type Count: 0";
            // 
            // cbSigTypes
            // 
            this.cbSigTypes.BackColor = System.Drawing.Color.LavenderBlush;
            this.cbSigTypes.FormattingEnabled = true;
            this.cbSigTypes.Location = new System.Drawing.Point(175, 249);
            this.cbSigTypes.MaxDropDownItems = 10;
            this.cbSigTypes.Name = "cbSigTypes";
            this.cbSigTypes.Size = new System.Drawing.Size(333, 21);
            this.cbSigTypes.TabIndex = 59;
            // 
            // lblSigTypes
            // 
            this.lblSigTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSigTypes.AutoSize = true;
            this.lblSigTypes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSigTypes.Location = new System.Drawing.Point(6, 252);
            this.lblSigTypes.Name = "lblSigTypes";
            this.lblSigTypes.Size = new System.Drawing.Size(163, 13);
            this.lblSigTypes.TabIndex = 58;
            this.lblSigTypes.Text = "Possible Types By File Signature:";
            this.lblSigTypes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBase64Content
            // 
            this.lblBase64Content.AutoSize = true;
            this.lblBase64Content.ForeColor = System.Drawing.Color.Sienna;
            this.lblBase64Content.Location = new System.Drawing.Point(63, 182);
            this.lblBase64Content.Name = "lblBase64Content";
            this.lblBase64Content.Size = new System.Drawing.Size(52, 13);
            this.lblBase64Content.TabIndex = 57;
            this.lblBase64Content.Text = "Length: 0";
            // 
            // cbAutoConvert
            // 
            this.cbAutoConvert.AutoSize = true;
            this.cbAutoConvert.Checked = true;
            this.cbAutoConvert.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAutoConvert.Location = new System.Drawing.Point(202, 24);
            this.cbAutoConvert.Name = "cbAutoConvert";
            this.cbAutoConvert.Size = new System.Drawing.Size(213, 17);
            this.cbAutoConvert.TabIndex = 56;
            this.cbAutoConvert.Text = "Auto Convert Base64 to File After Paste";
            this.cbAutoConvert.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(185, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "<-   Or  ->";
            // 
            // cbExtensions
            // 
            this.cbExtensions.BackColor = System.Drawing.SystemColors.Info;
            this.cbExtensions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cbExtensions.FormattingEnabled = true;
            this.cbExtensions.Items.AddRange(new object[] {
            "Excel (*.xlsx, *.xls)",
            "PDF (*.pdf)",
            "Image (*.png, *.jpg, *.gif)",
            "Text (*.txt, *.xml, *.htm)",
            "Word (*.docx, *.doc)"});
            this.cbExtensions.Location = new System.Drawing.Point(284, 287);
            this.cbExtensions.Name = "cbExtensions";
            this.cbExtensions.Size = new System.Drawing.Size(171, 23);
            this.cbExtensions.TabIndex = 54;
            this.cbExtensions.Text = "File Format (Default: *.txt)";
            // 
            // btnPreview
            // 
            this.btnPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPreview.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPreview.ImageIndex = 14;
            this.btnPreview.ImageList = this.imageListAction;
            this.btnPreview.Location = new System.Drawing.Point(461, 285);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(133, 25);
            this.btnPreview.TabIndex = 53;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreviewExcel_Click);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSaveAs.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSaveAs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveAs.ImageIndex = 7;
            this.btnSaveAs.ImageList = this.imageListAction;
            this.btnSaveAs.Location = new System.Drawing.Point(9, 287);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(129, 25);
            this.btnSaveAs.TabIndex = 52;
            this.btnSaveAs.Text = "Save As";
            this.btnSaveAs.UseVisualStyleBackColor = true;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // txtBase64Info
            // 
            this.txtBase64Info.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtBase64Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtBase64Info.Location = new System.Drawing.Point(63, 213);
            this.txtBase64Info.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBase64Info.MaxLength = 50;
            this.txtBase64Info.Name = "txtBase64Info";
            this.txtBase64Info.ReadOnly = true;
            this.txtBase64Info.Size = new System.Drawing.Size(409, 20);
            this.txtBase64Info.TabIndex = 51;
            this.txtBase64Info.TabStop = false;
            // 
            // lblBase64Info
            // 
            this.lblBase64Info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBase64Info.AutoSize = true;
            this.lblBase64Info.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBase64Info.Location = new System.Drawing.Point(6, 218);
            this.lblBase64Info.Name = "lblBase64Info";
            this.lblBase64Info.Size = new System.Drawing.Size(50, 13);
            this.lblBase64Info.TabIndex = 50;
            this.lblBase64Info.Text = "File Info :";
            this.lblBase64Info.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnBase64Convert
            // 
            this.btnBase64Convert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBase64Convert.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnBase64Convert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBase64Convert.ImageIndex = 11;
            this.btnBase64Convert.ImageList = this.imageListAction;
            this.btnBase64Convert.Location = new System.Drawing.Point(483, 210);
            this.btnBase64Convert.Name = "btnBase64Convert";
            this.btnBase64Convert.Size = new System.Drawing.Size(111, 25);
            this.btnBase64Convert.TabIndex = 49;
            this.btnBase64Convert.Text = "Convert";
            this.btnBase64Convert.UseVisualStyleBackColor = true;
            this.btnBase64Convert.Click += new System.EventHandler(this.btnBase64Convert_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPaste.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnPaste.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaste.ImageKey = "068.png";
            this.btnPaste.ImageList = this.imageListAction;
            this.btnPaste.Location = new System.Drawing.Point(421, 19);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(173, 25);
            this.btnPaste.TabIndex = 47;
            this.btnPaste.Text = "Paste From Clipboard";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // lblBase64_2
            // 
            this.lblBase64_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBase64_2.AutoSize = true;
            this.lblBase64_2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBase64_2.Location = new System.Drawing.Point(6, 55);
            this.lblBase64_2.Name = "lblBase64_2";
            this.lblBase64_2.Size = new System.Drawing.Size(49, 13);
            this.lblBase64_2.TabIndex = 45;
            this.lblBase64_2.Text = "Base64 :";
            this.lblBase64_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBase64Content
            // 
            this.txtBase64Content.BackColor = System.Drawing.SystemColors.Info;
            this.txtBase64Content.Location = new System.Drawing.Point(63, 55);
            this.txtBase64Content.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBase64Content.MaxLength = 0;
            this.txtBase64Content.Multiline = true;
            this.txtBase64Content.Name = "txtBase64Content";
            this.txtBase64Content.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBase64Content.Size = new System.Drawing.Size(531, 123);
            this.txtBase64Content.TabIndex = 44;
            this.txtBase64Content.TextChanged += new System.EventHandler(this.txtBase64Content_TextChanged);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblPoweredBy,
            this.sp1,
            this.tslblRecords});
            this.statusStrip.Location = new System.Drawing.Point(0, 654);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(634, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 14;
            this.statusStrip.Text = "statusStrip";
            // 
            // tslblPoweredBy
            // 
            this.tslblPoweredBy.Image = global::Base64Tools.Properties.Resources.about;
            this.tslblPoweredBy.IsLink = true;
            this.tslblPoweredBy.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.tslblPoweredBy.LinkColor = System.Drawing.SystemColors.WindowText;
            this.tslblPoweredBy.Name = "tslblPoweredBy";
            this.tslblPoweredBy.Size = new System.Drawing.Size(158, 17);
            this.tslblPoweredBy.Text = "Version 1.1.1 @ XAMT.Pro";
            this.tslblPoweredBy.ToolTipText = "Powered by XAMT.Pro";
            this.tslblPoweredBy.Click += new System.EventHandler(this.tslblPoweredBy_Click);
            // 
            // sp1
            // 
            this.sp1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.sp1.Name = "sp1";
            this.sp1.Size = new System.Drawing.Size(22, 17);
            this.sp1.Text = "  |  ";
            // 
            // tslblRecords
            // 
            this.tslblRecords.Image = global::Base64Tools.Properties.Resources._014;
            this.tslblRecords.Name = "tslblRecords";
            this.tslblRecords.Size = new System.Drawing.Size(222, 17);
            this.tslblRecords.Text = "File Signature Database: 536 (Records)";
            this.tslblRecords.ToolTipText = "Record Counts Available in File Signature Database to Guess what is the file type" +
    "";
            // 
            // btnReload
            // 
            this.btnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReload.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnReload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReload.ImageKey = "reset.png";
            this.btnReload.ImageList = this.imageListAction;
            this.btnReload.Location = new System.Drawing.Point(12, 617);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(90, 25);
            this.btnReload.TabIndex = 11;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.ImageKey = "cancel.png";
            this.btnCancel.ImageList = this.imageListAction;
            this.btnCancel.Location = new System.Drawing.Point(529, 617);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 25);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Exit";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 676);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.gbBase64ToFile);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.ToBase64_GB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Base 64 Helper";
            this.ToBase64_GB.ResumeLayout(false);
            this.ToBase64_GB.PerformLayout();
            this.gbBase64ToFile.ResumeLayout(false);
            this.gbBase64ToFile.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSigTypes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ToBase64_GB;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ImageList imageListAction;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.GroupBox gbBase64ToFile;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.Label lblBase64_2;
        private System.Windows.Forms.TextBox txtBase64Content;
        private System.Windows.Forms.TextBox txtBase64Info;
        private System.Windows.Forms.Label lblBase64Info;
        private System.Windows.Forms.Button btnBase64Convert;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnSaveAs;
        private System.Windows.Forms.ComboBox cbExtensions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbAutoConvert;
        private System.Windows.Forms.Label lblContentLength;
        private System.Windows.Forms.Label lblBase64Content;
        private System.Windows.Forms.Label lblSigTypes;
        private System.Windows.Forms.ComboBox cbSigTypes;
        private System.Windows.Forms.Label lbSigTypesCount;
        private System.Windows.Forms.BindingSource bsSigTypes;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tslblPoweredBy;
        private System.Windows.Forms.ToolStripStatusLabel sp1;
        private System.Windows.Forms.ToolStripStatusLabel tslblRecords;
        private System.Windows.Forms.CheckBox cbAutoLineBreak;
    }
}

