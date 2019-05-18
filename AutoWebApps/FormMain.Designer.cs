namespace Hans.Web
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent( )
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip( );
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel( );
            this.ButtonExit = new System.Windows.Forms.Button( );
            this.DialogPath = new System.Windows.Forms.FolderBrowserDialog( );
            this.DialogFile = new System.Windows.Forms.OpenFileDialog( );
            this.groupBox1 = new System.Windows.Forms.GroupBox( );
            this.ButtonHtmlPHP = new System.Windows.Forms.Button( );
            this.label1 = new System.Windows.Forms.Label( );
            this.TextHtmlPHP = new System.Windows.Forms.TextBox( );
            this.ButtonExecPHP = new System.Windows.Forms.Button( );
            this.ButtonHtmlJSP = new System.Windows.Forms.Button( );
            this.label2 = new System.Windows.Forms.Label( );
            this.TextHtmlJSP = new System.Windows.Forms.TextBox( );
            this.ButtonExecJSP = new System.Windows.Forms.Button( );
            this.groupBox2 = new System.Windows.Forms.GroupBox( );
            this.ButtonCopying = new System.Windows.Forms.Button( );
            this.ButtonApache = new System.Windows.Forms.Button( );
            this.label4 = new System.Windows.Forms.Label( );
            this.TextApache = new System.Windows.Forms.TextBox( );
            this.ButtonGithub = new System.Windows.Forms.Button( );
            this.label3 = new System.Windows.Forms.Label( );
            this.TextGithub = new System.Windows.Forms.TextBox( );
            this.ButtonFirefoxPHP = new System.Windows.Forms.Button( );
            this.statusStrip1.SuspendLayout( );
            this.groupBox1.SuspendLayout( );
            this.groupBox2.SuspendLayout( );
            this.SuspendLayout( );
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange( new System.Windows.Forms.ToolStripItem[ ] {
            this.toolStripStatusLabel1} );
            this.statusStrip1.Location = new System.Drawing.Point( 0, 494 );
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding( 1, 0, 16, 0 );
            this.statusStrip1.Size = new System.Drawing.Size( 584, 22 );
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font( "SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 134 ) ) );
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Blue;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size( 215, 17 );
            this.toolStripStatusLabel1.Text = "CGN WuJianHua (rev.2.0.190509)";
            // 
            // ButtonExit
            // 
            this.ButtonExit.Font = new System.Drawing.Font( "SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 134 ) ) );
            this.ButtonExit.Location = new System.Drawing.Point( 494, 459 );
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size( 75, 23 );
            this.ButtonExit.TabIndex = 1;
            this.ButtonExit.Text = "退出";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler( this.ButtonExit_Click );
            // 
            // DialogFile
            // 
            this.DialogFile.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add( this.ButtonFirefoxPHP );
            this.groupBox1.Controls.Add( this.ButtonHtmlPHP );
            this.groupBox1.Controls.Add( this.label1 );
            this.groupBox1.Controls.Add( this.TextHtmlPHP );
            this.groupBox1.Controls.Add( this.ButtonExecPHP );
            this.groupBox1.Controls.Add( this.ButtonHtmlJSP );
            this.groupBox1.Controls.Add( this.label2 );
            this.groupBox1.Controls.Add( this.TextHtmlJSP );
            this.groupBox1.Controls.Add( this.ButtonExecJSP );
            this.groupBox1.Location = new System.Drawing.Point( 12, 12 );
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size( 557, 203 );
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "自动加载 JSP/PHP";
            // 
            // ButtonHtmlPHP
            // 
            this.ButtonHtmlPHP.Font = new System.Drawing.Font( "SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 134 ) ) );
            this.ButtonHtmlPHP.Location = new System.Drawing.Point( 514, 93 );
            this.ButtonHtmlPHP.Name = "ButtonHtmlPHP";
            this.ButtonHtmlPHP.Size = new System.Drawing.Size( 25, 23 );
            this.ButtonHtmlPHP.TabIndex = 20;
            this.ButtonHtmlPHP.Text = "...";
            this.ButtonHtmlPHP.UseVisualStyleBackColor = true;
            this.ButtonHtmlPHP.Click += new System.EventHandler( this.ButtonHtmlPHP_Click );
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point( 24, 98 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 72, 12 );
            this.label1.TabIndex = 19;
            this.label1.Text = "PHP 文件：";
            // 
            // TextHtmlPHP
            // 
            this.TextHtmlPHP.Location = new System.Drawing.Point( 116, 95 );
            this.TextHtmlPHP.Name = "TextHtmlPHP";
            this.TextHtmlPHP.Size = new System.Drawing.Size( 392, 21 );
            this.TextHtmlPHP.TabIndex = 18;
            this.TextHtmlPHP.Text = "C:\\Apache24v15x64\\htdocs\\csn\\nps.index.php";
            // 
            // ButtonExecPHP
            // 
            this.ButtonExecPHP.Font = new System.Drawing.Font( "SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 134 ) ) );
            this.ButtonExecPHP.Location = new System.Drawing.Point( 297, 122 );
            this.ButtonExecPHP.Name = "ButtonExecPHP";
            this.ButtonExecPHP.Size = new System.Drawing.Size( 242, 23 );
            this.ButtonExecPHP.TabIndex = 17;
            this.ButtonExecPHP.Text = "IE, 加载PHP";
            this.ButtonExecPHP.UseVisualStyleBackColor = true;
            this.ButtonExecPHP.Click += new System.EventHandler( this.ButtonExecPHP_Click );
            // 
            // ButtonHtmlJSP
            // 
            this.ButtonHtmlJSP.Font = new System.Drawing.Font( "SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 134 ) ) );
            this.ButtonHtmlJSP.Location = new System.Drawing.Point( 514, 27 );
            this.ButtonHtmlJSP.Name = "ButtonHtmlJSP";
            this.ButtonHtmlJSP.Size = new System.Drawing.Size( 25, 23 );
            this.ButtonHtmlJSP.TabIndex = 16;
            this.ButtonHtmlJSP.Text = "...";
            this.ButtonHtmlJSP.UseVisualStyleBackColor = true;
            this.ButtonHtmlJSP.Click += new System.EventHandler( this.ButtonHtmlJSP_Click );
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point( 24, 32 );
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size( 72, 12 );
            this.label2.TabIndex = 15;
            this.label2.Text = "JSP 文件：";
            // 
            // TextHtmlJSP
            // 
            this.TextHtmlJSP.Location = new System.Drawing.Point( 116, 29 );
            this.TextHtmlJSP.Name = "TextHtmlJSP";
            this.TextHtmlJSP.Size = new System.Drawing.Size( 392, 21 );
            this.TextHtmlJSP.TabIndex = 14;
            this.TextHtmlJSP.Text = "C:\\Tomcat80\\webapps\\manager\\index.jsp";
            // 
            // ButtonExecJSP
            // 
            this.ButtonExecJSP.Font = new System.Drawing.Font( "SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 134 ) ) );
            this.ButtonExecJSP.Location = new System.Drawing.Point( 297, 56 );
            this.ButtonExecJSP.Name = "ButtonExecJSP";
            this.ButtonExecJSP.Size = new System.Drawing.Size( 242, 23 );
            this.ButtonExecJSP.TabIndex = 13;
            this.ButtonExecJSP.Text = "加载JSP";
            this.ButtonExecJSP.UseVisualStyleBackColor = true;
            this.ButtonExecJSP.Click += new System.EventHandler( this.ButtonExecJSP_Click );
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add( this.ButtonCopying );
            this.groupBox2.Controls.Add( this.ButtonApache );
            this.groupBox2.Controls.Add( this.label4 );
            this.groupBox2.Controls.Add( this.TextApache );
            this.groupBox2.Controls.Add( this.ButtonGithub );
            this.groupBox2.Controls.Add( this.label3 );
            this.groupBox2.Controls.Add( this.TextGithub );
            this.groupBox2.Location = new System.Drawing.Point( 15, 239 );
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size( 557, 146 );
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "复制开发项目进入测试环境";
            // 
            // ButtonCopying
            // 
            this.ButtonCopying.Font = new System.Drawing.Font( "SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 134 ) ) );
            this.ButtonCopying.Location = new System.Drawing.Point( 297, 107 );
            this.ButtonCopying.Name = "ButtonCopying";
            this.ButtonCopying.Size = new System.Drawing.Size( 242, 23 );
            this.ButtonCopying.TabIndex = 23;
            this.ButtonCopying.Text = "复制项目文件到测试环境";
            this.ButtonCopying.UseVisualStyleBackColor = true;
            this.ButtonCopying.Click += new System.EventHandler( this.ButtonCopying_Click );
            // 
            // ButtonApache
            // 
            this.ButtonApache.Font = new System.Drawing.Font( "SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 134 ) ) );
            this.ButtonApache.Location = new System.Drawing.Point( 514, 68 );
            this.ButtonApache.Name = "ButtonApache";
            this.ButtonApache.Size = new System.Drawing.Size( 25, 23 );
            this.ButtonApache.TabIndex = 22;
            this.ButtonApache.Text = "...";
            this.ButtonApache.UseVisualStyleBackColor = true;
            this.ButtonApache.Click += new System.EventHandler( this.ButtonApache_Click );
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point( 24, 73 );
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size( 122, 12 );
            this.label4.TabIndex = 21;
            this.label4.Text = "测试服务器根目录：";
            // 
            // TextApache
            // 
            this.TextApache.Location = new System.Drawing.Point( 163, 70 );
            this.TextApache.Name = "TextApache";
            this.TextApache.Size = new System.Drawing.Size( 345, 21 );
            this.TextApache.TabIndex = 20;
            this.TextApache.Text = "C:\\Apache24v15x64\\htdocs\\csn";
            // 
            // ButtonGithub
            // 
            this.ButtonGithub.Font = new System.Drawing.Font( "SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 134 ) ) );
            this.ButtonGithub.Location = new System.Drawing.Point( 514, 31 );
            this.ButtonGithub.Name = "ButtonGithub";
            this.ButtonGithub.Size = new System.Drawing.Size( 25, 23 );
            this.ButtonGithub.TabIndex = 19;
            this.ButtonGithub.Text = "...";
            this.ButtonGithub.UseVisualStyleBackColor = true;
            this.ButtonGithub.Click += new System.EventHandler( this.ButtonGithub_Click );
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point( 24, 36 );
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size( 109, 12 );
            this.label3.TabIndex = 18;
            this.label3.Text = "开发环境根目录：";
            // 
            // TextGithub
            // 
            this.TextGithub.Location = new System.Drawing.Point( 163, 33 );
            this.TextGithub.Name = "TextGithub";
            this.TextGithub.Size = new System.Drawing.Size( 345, 21 );
            this.TextGithub.TabIndex = 17;
            this.TextGithub.Text = "D:\\Hans-GitHub\\PHP.CSN.Wasser";
            // 
            // ButtonFirefoxPHP
            // 
            this.ButtonFirefoxPHP.Font = new System.Drawing.Font( "SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 134 ) ) );
            this.ButtonFirefoxPHP.Location = new System.Drawing.Point( 297, 151 );
            this.ButtonFirefoxPHP.Name = "ButtonFirefoxPHP";
            this.ButtonFirefoxPHP.Size = new System.Drawing.Size( 242, 23 );
            this.ButtonFirefoxPHP.TabIndex = 21;
            this.ButtonFirefoxPHP.Text = "加载PHP (Firefox)";
            this.ButtonFirefoxPHP.UseVisualStyleBackColor = true;
            this.ButtonFirefoxPHP.Click += new System.EventHandler( this.ButtonFirefoxPHP_Click );
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 7F, 12F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 584, 516 );
            this.Controls.Add( this.groupBox2 );
            this.Controls.Add( this.groupBox1 );
            this.Controls.Add( this.ButtonExit );
            this.Controls.Add( this.statusStrip1 );
            this.Font = new System.Drawing.Font( "SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 134 ) ) );
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "快速加载webapp";
            this.Load += new System.EventHandler( this.FormMain_Load );
            this.statusStrip1.ResumeLayout( false );
            this.statusStrip1.PerformLayout( );
            this.groupBox1.ResumeLayout( false );
            this.groupBox1.PerformLayout( );
            this.groupBox2.ResumeLayout( false );
            this.groupBox2.PerformLayout( );
            this.ResumeLayout( false );
            this.PerformLayout( );

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.FolderBrowserDialog DialogPath;
        private System.Windows.Forms.OpenFileDialog DialogFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ButtonHtmlPHP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextHtmlPHP;
        private System.Windows.Forms.Button ButtonExecPHP;
        private System.Windows.Forms.Button ButtonHtmlJSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextHtmlJSP;
        private System.Windows.Forms.Button ButtonExecJSP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ButtonCopying;
        private System.Windows.Forms.Button ButtonApache;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextApache;
        private System.Windows.Forms.Button ButtonGithub;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextGithub;
        private System.Windows.Forms.Button ButtonFirefoxPHP;
    }
}

