namespace OnvifCapture
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_up = new System.Windows.Forms.Button();
            this.btn_right = new System.Windows.Forms.Button();
            this.btn_left = new System.Windows.Forms.Button();
            this.btn_down = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ipAddress1 = new System.Windows.Forms.TextBox();
            this.txt_id1 = new System.Windows.Forms.TextBox();
            this.txt_port1 = new System.Windows.Forms.TextBox();
            this.txt_password1 = new System.Windows.Forms.TextBox();
            this.txt_password2 = new System.Windows.Forms.TextBox();
            this.txt_port2 = new System.Windows.Forms.TextBox();
            this.txt_id2 = new System.Windows.Forms.TextBox();
            this.txt_ipAddress2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.btn_connect1 = new System.Windows.Forms.Button();
            this.btn_connect2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pan_trackerBar = new System.Windows.Forms.TrackBar();
            this.tilt_trackerBar = new System.Windows.Forms.TrackBar();
            this.pan_numeric = new System.Windows.Forms.NumericUpDown();
            this.tilt_numeric = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.trackBar5 = new System.Windows.Forms.TrackBar();
            this.trackBar6 = new System.Windows.Forms.TrackBar();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.videoGrabber1 = new VidGrab.VideoGrabber();
            this.videoGrabber2 = new VidGrab.VideoGrabber();
            this.videoGrabber3 = new VidGrab.VideoGrabber();
            this.lbl_speed = new System.Windows.Forms.Label();
            this.speed_trackerBar = new System.Windows.Forms.TrackBar();
            this.lbl_duration = new System.Windows.Forms.Label();
            this.txt_duration = new System.Windows.Forms.TextBox();
            this.btn_zoom_in = new System.Windows.Forms.Button();
            this.btn_zoom_out = new System.Windows.Forms.Button();
            this.lbl_relative_move = new System.Windows.Forms.Label();
            this.txt_relative_move = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pan_trackerBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tilt_trackerBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pan_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tilt_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speed_trackerBar)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_up
            // 
            this.btn_up.Location = new System.Drawing.Point(273, 510);
            this.btn_up.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(90, 35);
            this.btn_up.TabIndex = 2;
            this.btn_up.Text = "Up";
            this.btn_up.UseVisualStyleBackColor = true;
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            this.btn_up.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_up_MouseDown);
            // 
            // btn_right
            // 
            this.btn_right.Location = new System.Drawing.Point(362, 553);
            this.btn_right.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(90, 35);
            this.btn_right.TabIndex = 3;
            this.btn_right.Text = "Right";
            this.btn_right.UseVisualStyleBackColor = true;
            this.btn_right.Click += new System.EventHandler(this.btn_right_Click);
            this.btn_right.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_right_MouseDown);
            // 
            // btn_left
            // 
            this.btn_left.Location = new System.Drawing.Point(176, 553);
            this.btn_left.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(90, 35);
            this.btn_left.TabIndex = 4;
            this.btn_left.Text = "Left";
            this.btn_left.UseVisualStyleBackColor = true;
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
            this.btn_left.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_left_MouseDown);
            // 
            // btn_down
            // 
            this.btn_down.Location = new System.Drawing.Point(273, 604);
            this.btn_down.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(90, 35);
            this.btn_down.TabIndex = 5;
            this.btn_down.Text = "Down";
            this.btn_down.UseVisualStyleBackColor = true;
            this.btn_down.Click += new System.EventHandler(this.btn_down_Click);
            this.btn_down.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_down_MouseDown);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(35, 557);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 35);
            this.button5.TabIndex = 6;
            this.button5.Text = "Zoom in";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(35, 603);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(90, 35);
            this.button6.TabIndex = 7;
            this.button6.Text = "Zoom out";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(35, 657);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(90, 35);
            this.button7.TabIndex = 8;
            this.button7.Text = "Focus in";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(35, 700);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(90, 35);
            this.button8.TabIndex = 9;
            this.button8.Text = "Focus out";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(147, 700);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(90, 35);
            this.button9.TabIndex = 10;
            this.button9.Text = "사진 저장(jpg)";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "IP Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "PORT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "PW";
            // 
            // txt_ipAddress1
            // 
            this.txt_ipAddress1.Location = new System.Drawing.Point(140, 40);
            this.txt_ipAddress1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ipAddress1.Name = "txt_ipAddress1";
            this.txt_ipAddress1.Size = new System.Drawing.Size(114, 25);
            this.txt_ipAddress1.TabIndex = 15;
            // 
            // txt_id1
            // 
            this.txt_id1.Location = new System.Drawing.Point(140, 81);
            this.txt_id1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_id1.Name = "txt_id1";
            this.txt_id1.Size = new System.Drawing.Size(114, 25);
            this.txt_id1.TabIndex = 16;
            // 
            // txt_port1
            // 
            this.txt_port1.Location = new System.Drawing.Point(328, 36);
            this.txt_port1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_port1.Name = "txt_port1";
            this.txt_port1.Size = new System.Drawing.Size(114, 25);
            this.txt_port1.TabIndex = 17;
            // 
            // txt_password1
            // 
            this.txt_password1.Location = new System.Drawing.Point(328, 78);
            this.txt_password1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_password1.Name = "txt_password1";
            this.txt_password1.Size = new System.Drawing.Size(114, 25);
            this.txt_password1.TabIndex = 18;
            // 
            // txt_password2
            // 
            this.txt_password2.Location = new System.Drawing.Point(1080, 76);
            this.txt_password2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_password2.Name = "txt_password2";
            this.txt_password2.Size = new System.Drawing.Size(114, 25);
            this.txt_password2.TabIndex = 26;
            // 
            // txt_port2
            // 
            this.txt_port2.Location = new System.Drawing.Point(1080, 35);
            this.txt_port2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_port2.Name = "txt_port2";
            this.txt_port2.Size = new System.Drawing.Size(114, 25);
            this.txt_port2.TabIndex = 25;
            // 
            // txt_id2
            // 
            this.txt_id2.Location = new System.Drawing.Point(893, 80);
            this.txt_id2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_id2.Name = "txt_id2";
            this.txt_id2.Size = new System.Drawing.Size(114, 25);
            this.txt_id2.TabIndex = 24;
            // 
            // txt_ipAddress2
            // 
            this.txt_ipAddress2.Location = new System.Drawing.Point(893, 39);
            this.txt_ipAddress2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ipAddress2.Name = "txt_ipAddress2";
            this.txt_ipAddress2.Size = new System.Drawing.Size(114, 25);
            this.txt_ipAddress2.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1043, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "PW";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(862, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1030, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "PORT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(804, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "IP Address";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(823, 734);
            this.button10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(90, 35);
            this.button10.TabIndex = 35;
            this.button10.Text = "사진 저장(jpg)";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(695, 742);
            this.button11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(90, 35);
            this.button11.TabIndex = 34;
            this.button11.Text = "Focus out";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(695, 700);
            this.button12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(90, 35);
            this.button12.TabIndex = 33;
            this.button12.Text = "Focus in";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(695, 646);
            this.button13.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(90, 35);
            this.button13.TabIndex = 32;
            this.button13.Text = "Zoom out";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(695, 600);
            this.button14.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(90, 35);
            this.button14.TabIndex = 31;
            this.button14.Text = "Zoom in";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(917, 630);
            this.button15.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(90, 35);
            this.button15.TabIndex = 30;
            this.button15.Text = "Down";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(823, 587);
            this.button16.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(90, 35);
            this.button16.TabIndex = 29;
            this.button16.Text = "Left";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(1010, 587);
            this.button17.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(90, 35);
            this.button17.TabIndex = 28;
            this.button17.Text = "Right";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(917, 549);
            this.button18.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(90, 35);
            this.button18.TabIndex = 27;
            this.button18.Text = "Up";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // btn_connect1
            // 
            this.btn_connect1.Location = new System.Drawing.Point(36, 519);
            this.btn_connect1.Name = "btn_connect1";
            this.btn_connect1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_connect1.Size = new System.Drawing.Size(142, 26);
            this.btn_connect1.TabIndex = 36;
            this.btn_connect1.Text = "Connect";
            this.btn_connect1.UseVisualStyleBackColor = true;
            this.btn_connect1.Click += new System.EventHandler(this.btn_connect1_Click);
            // 
            // btn_connect2
            // 
            this.btn_connect2.Location = new System.Drawing.Point(695, 553);
            this.btn_connect2.Name = "btn_connect2";
            this.btn_connect2.Size = new System.Drawing.Size(142, 26);
            this.btn_connect2.TabIndex = 37;
            this.btn_connect2.Text = "Connect";
            this.btn_connect2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(286, 657);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 15);
            this.label10.TabIndex = 39;
            this.label10.Text = "Pan";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(286, 710);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 15);
            this.label11.TabIndex = 40;
            this.label11.Text = "Tilt";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(274, 756);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 15);
            this.label12.TabIndex = 41;
            this.label12.Text = "Zoom";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(927, 752);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 15);
            this.label13.TabIndex = 47;
            this.label13.Text = "Zoom";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(927, 720);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 15);
            this.label14.TabIndex = 46;
            this.label14.Text = "Tilt";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(927, 691);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 15);
            this.label15.TabIndex = 45;
            this.label15.Text = "Pan";
            // 
            // pan_trackerBar
            // 
            this.pan_trackerBar.Location = new System.Drawing.Point(325, 650);
            this.pan_trackerBar.Maximum = 1000;
            this.pan_trackerBar.Name = "pan_trackerBar";
            this.pan_trackerBar.Size = new System.Drawing.Size(110, 56);
            this.pan_trackerBar.TabIndex = 51;
            this.pan_trackerBar.Value = 500;
            this.pan_trackerBar.Scroll += new System.EventHandler(this.pan_trackerBar_Scroll);
            // 
            // tilt_trackerBar
            // 
            this.tilt_trackerBar.Location = new System.Drawing.Point(325, 700);
            this.tilt_trackerBar.Maximum = 1000;
            this.tilt_trackerBar.Name = "tilt_trackerBar";
            this.tilt_trackerBar.Size = new System.Drawing.Size(110, 56);
            this.tilt_trackerBar.TabIndex = 52;
            this.tilt_trackerBar.Value = 500;
            this.tilt_trackerBar.Scroll += new System.EventHandler(this.tilt_trackerBar_Scroll);
            // 
            // pan_numeric
            // 
            this.pan_numeric.DecimalPlaces = 1;
            this.pan_numeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.pan_numeric.Location = new System.Drawing.Point(432, 650);
            this.pan_numeric.Name = "pan_numeric";
            this.pan_numeric.Size = new System.Drawing.Size(99, 25);
            this.pan_numeric.TabIndex = 54;
            this.pan_numeric.Value = new decimal(new int[] {
            500,
            0,
            0,
            65536});
            this.pan_numeric.ValueChanged += new System.EventHandler(this.pan_numeric_ValueChanged);
            // 
            // tilt_numeric
            // 
            this.tilt_numeric.DecimalPlaces = 1;
            this.tilt_numeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.tilt_numeric.Location = new System.Drawing.Point(432, 703);
            this.tilt_numeric.Name = "tilt_numeric";
            this.tilt_numeric.Size = new System.Drawing.Size(99, 25);
            this.tilt_numeric.TabIndex = 55;
            this.tilt_numeric.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.tilt_numeric.ValueChanged += new System.EventHandler(this.tilt_numeric_ValueChanged);
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(1078, 757);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(99, 25);
            this.numericUpDown4.TabIndex = 62;
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(1078, 722);
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(99, 25);
            this.numericUpDown5.TabIndex = 61;
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Location = new System.Drawing.Point(1078, 686);
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(99, 25);
            this.numericUpDown6.TabIndex = 60;
            // 
            // trackBar4
            // 
            this.trackBar4.Location = new System.Drawing.Point(971, 751);
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(110, 56);
            this.trackBar4.TabIndex = 59;
            // 
            // trackBar5
            // 
            this.trackBar5.Location = new System.Drawing.Point(971, 715);
            this.trackBar5.Name = "trackBar5";
            this.trackBar5.Size = new System.Drawing.Size(110, 56);
            this.trackBar5.TabIndex = 58;
            // 
            // trackBar6
            // 
            this.trackBar6.Location = new System.Drawing.Point(971, 688);
            this.trackBar6.Name = "trackBar6";
            this.trackBar6.Size = new System.Drawing.Size(110, 56);
            this.trackBar6.TabIndex = 57;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1239, 27);
            this.bindingNavigator1.TabIndex = 65;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "새로 추가";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(33, 24);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "전체 항목 수";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "삭제";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "처음으로 이동";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "이전으로 이동";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "위치";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "현재 위치";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "다음으로 이동";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "마지막으로 이동";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // videoGrabber1
            // 
            this.videoGrabber1.AdjustOverlayAspectRatio = true;
            this.videoGrabber1.AdjustPixelAspectRatio = true;
            this.videoGrabber1.Aero = VidGrab.TAero.ae_Default;
            this.videoGrabber1.AnalogVideoStandard = -1;
            this.videoGrabber1.ApplicationPriority = VidGrab.TApplicationPriority.ap_default;
            this.videoGrabber1.ASFAudioBitRate = -1;
            this.videoGrabber1.ASFAudioChannels = -1;
            this.videoGrabber1.ASFBufferWindow = -1;
            this.videoGrabber1.ASFDeinterlaceMode = VidGrab.TASFDeinterlaceMode.adm_NotInterlaced;
            this.videoGrabber1.ASFDirectStreamingKeepClientsConnected = false;
            this.videoGrabber1.ASFFixedFrameRate = true;
            this.videoGrabber1.ASFMediaServerPublishingPoint = "";
            this.videoGrabber1.ASFMediaServerRemovePublishingPointAfterDisconnect = false;
            this.videoGrabber1.ASFMediaServerTemplatePublishingPoint = "";
            this.videoGrabber1.ASFNetworkMaxUsers = 5;
            this.videoGrabber1.ASFNetworkPort = 0;
            this.videoGrabber1.ASFProfile = -1;
            this.videoGrabber1.ASFProfileFromCustomFile = "";
            this.videoGrabber1.ASFProfileVersion = VidGrab.TASFProfileVersion.apv_ProfileVersion_8;
            this.videoGrabber1.ASFVideoBitRate = -1;
            this.videoGrabber1.ASFVideoFrameRate = 0D;
            this.videoGrabber1.ASFVideoHeight = -1;
            this.videoGrabber1.ASFVideoMaxKeyFrameSpacing = -1;
            this.videoGrabber1.ASFVideoQuality = -1;
            this.videoGrabber1.ASFVideoWidth = -1;
            this.videoGrabber1.AspectRatioToUse = -1D;
            this.videoGrabber1.AssociateAudioAndVideoDevices = false;
            this.videoGrabber1.AudioChannelRenderMode = VidGrab.TAudioChannelRenderMode.acrm_PassThru;
            this.videoGrabber1.AudioCompressor = 0;
            this.videoGrabber1.AudioDevice = -1;
            this.videoGrabber1.AudioDeviceRendering = false;
            this.videoGrabber1.AudioFormat = VidGrab.TAudioFormat.af_default;
            this.videoGrabber1.AudioInput = -1;
            this.videoGrabber1.AudioPeakEvent = true;
            this.videoGrabber1.AudioRecording = false;
            this.videoGrabber1.AudioRenderer = -1;
            this.videoGrabber1.AudioSource = VidGrab.TAudioSource.as_Default;
            this.videoGrabber1.AudioStreamNumber = -1;
            this.videoGrabber1.AudioSyncAdjustment = 0;
            this.videoGrabber1.AudioSyncAdjustmentEnabled = false;
            this.videoGrabber1.AutoConnectRelatedPins = true;
            this.videoGrabber1.AutoFileName = VidGrab.TAutoFileName.fn_Sequential;
            this.videoGrabber1.AutoFileNameDateTimeFormat = "yymmdd_hhmmss_zzz";
            this.videoGrabber1.AutoFileNameMinDigits = 6;
            this.videoGrabber1.AutoFilePrefix = "vg";
            this.videoGrabber1.AutoFileSuffix = "";
            this.videoGrabber1.AutoRefreshPreview = false;
            this.videoGrabber1.AutoStartPlayer = true;
            this.videoGrabber1.AVIDurationUpdated = true;
            this.videoGrabber1.AVIFormatOpenDML = true;
            this.videoGrabber1.AVIFormatOpenDMLCompatibilityIndex = true;
            this.videoGrabber1.BackgroundColor = 0;
            this.videoGrabber1.BurstCount = 3;
            this.videoGrabber1.BurstInterval = 0;
            this.videoGrabber1.BurstMode = false;
            this.videoGrabber1.BurstType = VidGrab.TFrameCaptureDest.fc_TBitmap;
            this.videoGrabber1.BusyCursor = VidGrab.TCursors.cr_HourGlass;
            this.videoGrabber1.CameraControlSettings = true;
            this.videoGrabber1.CaptureFileExt = "";
            this.videoGrabber1.ColorKey = 1048592;
            this.videoGrabber1.ColorKeyEnabled = false;
            this.videoGrabber1.CompressionMode = VidGrab.TCompressionMode.cm_CompressOnTheFly;
            this.videoGrabber1.CompressionType = VidGrab.TCompressionType.ct_Video;
            this.videoGrabber1.Cropping_Enabled = false;
            this.videoGrabber1.Cropping_Height = 120;
            this.videoGrabber1.Cropping_Outbounds = true;
            this.videoGrabber1.Cropping_Width = 160;
            this.videoGrabber1.Cropping_X = 0;
            this.videoGrabber1.Cropping_Y = 0;
            this.videoGrabber1.Cropping_Zoom = 1D;
            this.videoGrabber1.Display_Active = true;
            this.videoGrabber1.Display_AlphaBlendEnabled = false;
            this.videoGrabber1.Display_AlphaBlendValue = 180;
            this.videoGrabber1.Display_AspectRatio = VidGrab.TAspectRatio.ar_Box;
            this.videoGrabber1.Display_AutoSize = false;
            this.videoGrabber1.Display_Embedded = true;
            this.videoGrabber1.Display_Embedded_FitParent = false;
            this.videoGrabber1.Display_FullScreen = false;
            this.videoGrabber1.Display_Height = 720;
            this.videoGrabber1.Display_Left = 10;
            this.videoGrabber1.Display_Monitor = 0;
            this.videoGrabber1.Display_MouseMovesWindow = true;
            this.videoGrabber1.Display_PanScanRatio = 50;
            this.videoGrabber1.Display_StayOnTop = false;
            this.videoGrabber1.Display_Top = 10;
            this.videoGrabber1.Display_TransparentColorEnabled = false;
            this.videoGrabber1.Display_TransparentColorValue = 255;
            this.videoGrabber1.Display_VideoPortEnabled = true;
            this.videoGrabber1.Display_Visible = true;
            this.videoGrabber1.Display_Width = 1280;
            this.videoGrabber1.DoubleBuffered = false;
            this.videoGrabber1.DroppedFramesPollingInterval = -1;
            this.videoGrabber1.DualDisplay_Active = false;
            this.videoGrabber1.DualDisplay_AlphaBlendEnabled = false;
            this.videoGrabber1.DualDisplay_AlphaBlendValue = 180;
            this.videoGrabber1.DualDisplay_AspectRatio = VidGrab.TAspectRatio.ar_Box;
            this.videoGrabber1.DualDisplay_AutoSize = false;
            this.videoGrabber1.DualDisplay_Embedded = false;
            this.videoGrabber1.DualDisplay_Embedded_FitParent = false;
            this.videoGrabber1.DualDisplay_FullScreen = false;
            this.videoGrabber1.DualDisplay_Height = 720;
            this.videoGrabber1.DualDisplay_Left = 20;
            this.videoGrabber1.DualDisplay_Monitor = 0;
            this.videoGrabber1.DualDisplay_MouseMovesWindow = true;
            this.videoGrabber1.DualDisplay_PanScanRatio = 50;
            this.videoGrabber1.DualDisplay_StayOnTop = false;
            this.videoGrabber1.DualDisplay_Top = 400;
            this.videoGrabber1.DualDisplay_TransparentColorEnabled = false;
            this.videoGrabber1.DualDisplay_TransparentColorValue = 255;
            this.videoGrabber1.DualDisplay_VideoPortEnabled = false;
            this.videoGrabber1.DualDisplay_Visible = true;
            this.videoGrabber1.DualDisplay_Width = 1280;
            this.videoGrabber1.DVDateTimeEnabled = true;
            this.videoGrabber1.DVDiscontinuityMinimumInterval = 3;
            this.videoGrabber1.DVDTitle = 0;
            this.videoGrabber1.DVEncoder_VideoFormat = VidGrab.TDVVideoFormat.dvf_DVSD;
            this.videoGrabber1.DVEncoder_VideoResolution = VidGrab.TDVSize.dv_Full;
            this.videoGrabber1.DVEncoder_VideoStandard = VidGrab.TDVVideoStandard.dvs_Default;
            this.videoGrabber1.DVRecordingInNativeFormatSeparatesStreams = false;
            this.videoGrabber1.DVReduceFrameRate = false;
            this.videoGrabber1.DVRgb219 = false;
            this.videoGrabber1.DVTimeCodeEnabled = false;
            this.videoGrabber1.EventNotificationSynchrone = true;
            this.videoGrabber1.ExtraDLLPath = "";
            this.videoGrabber1.FixFlickerOrBlackCapture = false;
            this.videoGrabber1.FrameCaptureHeight = -1;
            this.videoGrabber1.FrameCaptureWidth = -1;
            this.videoGrabber1.FrameCaptureWithoutOverlay = false;
            this.videoGrabber1.FrameCaptureZoomSize = 100;
            this.videoGrabber1.FrameGrabber = VidGrab.TFrameGrabber.fg_BothStreams;
            this.videoGrabber1.FrameGrabberRGBFormat = VidGrab.TFrameGrabberRGBFormat.fgf_Default;
            this.videoGrabber1.FrameNumberStartsFromZero = false;
            this.videoGrabber1.FrameRate = 0D;
            this.videoGrabber1.FrameRateDivider = 0;
            this.videoGrabber1.GeneratePts = false;
            this.videoGrabber1.GetLastFrameWaitTimeoutMs = 0;
            this.videoGrabber1.ImageOverlay_AlphaBlend = false;
            this.videoGrabber1.ImageOverlay_AlphaBlendValue = 180;
            this.videoGrabber1.ImageOverlay_ChromaKey = false;
            this.videoGrabber1.ImageOverlay_ChromaKeyLeewayPercent = 25;
            this.videoGrabber1.ImageOverlay_ChromaKeyRGBColor = 0;
            this.videoGrabber1.ImageOverlay_Height = -1;
            this.videoGrabber1.ImageOverlay_LeftLocation = 10;
            this.videoGrabber1.ImageOverlay_RotationAngle = 0D;
            this.videoGrabber1.ImageOverlay_StretchToVideoSize = false;
            this.videoGrabber1.ImageOverlay_TargetDisplay = -1;
            this.videoGrabber1.ImageOverlay_TopLocation = 10;
            this.videoGrabber1.ImageOverlay_Transparent = false;
            this.videoGrabber1.ImageOverlay_TransparentColorValue = 0;
            this.videoGrabber1.ImageOverlay_UseTransparentColor = false;
            this.videoGrabber1.ImageOverlay_VideoAlignment = VidGrab.TVideoAlignment.oa_LeftTop;
            this.videoGrabber1.ImageOverlay_Width = -1;
            this.videoGrabber1.ImageOverlayEnabled = false;
            this.videoGrabber1.IPCameraURL = "";
            this.videoGrabber1.JPEGPerformance = VidGrab.TJPEGPerformance.jpBestQuality;
            this.videoGrabber1.JPEGProgressiveDisplay = false;
            this.videoGrabber1.JPEGQuality = 100;
            this.videoGrabber1.LicenseString = "N/A";
            this.videoGrabber1.Location = new System.Drawing.Point(90, 191);
            this.videoGrabber1.LogoDisplayed = false;
            this.videoGrabber1.LogoLayout = VidGrab.TLogoLayout.lg_Stretched;
            this.videoGrabber1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.videoGrabber1.MixAudioSamples_CurrentSourceLevel = 100;
            this.videoGrabber1.MixAudioSamples_ExternalSourceLevel = 100;
            this.videoGrabber1.Mixer_MosaicColumns = 1;
            this.videoGrabber1.Mixer_MosaicLines = 1;
            this.videoGrabber1.MotionDetector_CompareBlue = true;
            this.videoGrabber1.MotionDetector_CompareGreen = true;
            this.videoGrabber1.MotionDetector_CompareRed = true;
            this.videoGrabber1.MotionDetector_Enabled = false;
            this.videoGrabber1.MotionDetector_GreyScale = false;
            this.videoGrabber1.MotionDetector_Grid = "5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555" +
    "555555 5555555555 5555555555";
            this.videoGrabber1.MotionDetector_MaxDetectionsPerSecond = 0D;
            this.videoGrabber1.MotionDetector_MotionResetMs = 0;
            this.videoGrabber1.MotionDetector_ReduceCPULoad = 1;
            this.videoGrabber1.MotionDetector_ReduceVideoNoise = false;
            this.videoGrabber1.MotionDetector_Triggered = false;
            this.videoGrabber1.MouseWheelControlsZoomAtCursor = false;
            this.videoGrabber1.MouseWheelEventEnabled = true;
            this.videoGrabber1.MultiplexedInputEmulation = true;
            this.videoGrabber1.MultiplexedRole = VidGrab.TMultiplexedRole.mr_NotMultiplexed;
            this.videoGrabber1.MultiplexedStabilizationDelay = 100;
            this.videoGrabber1.MultiplexedSwitchDelay = 0;
            this.videoGrabber1.Multiplexer = -1;
            this.videoGrabber1.MuteAudioRendering = false;
            this.videoGrabber1.Name = "videoGrabber1";
            this.videoGrabber1.NDIBandwidthType = VidGrab.TNDIBandwidthType.nbt_HighestBandwidth;
            this.videoGrabber1.NDIGroups = "";
            this.videoGrabber1.NDIName = "DATASTEAD_UNNAMED_SOURCE";
            this.videoGrabber1.NDIReceiveTimeoutMs = 5000;
            this.videoGrabber1.NetworkStreaming = VidGrab.TNetworkStreaming.ns_Disabled;
            this.videoGrabber1.NetworkStreamingType = VidGrab.TNetworkStreamingType.nst_AudioVideoStreaming;
            this.videoGrabber1.NormalCursor = VidGrab.TCursors.cr_Default;
            this.videoGrabber1.NotificationMethod = VidGrab.TNotificationMethod.nm_Thread;
            this.videoGrabber1.NotificationPriority = VidGrab.TThreadPriority.tpNormal;
            this.videoGrabber1.NotificationSleepTime = -1;
            this.videoGrabber1.OnFrameBitmapEventSynchrone = false;
            this.videoGrabber1.OpenURLAsync = true;
            this.videoGrabber1.OverlayAfterTransform = false;
            this.videoGrabber1.PlayerAudioRendering = true;
            this.videoGrabber1.PlayerDVSize = VidGrab.TDVSize.dv_Full;
            this.videoGrabber1.PlayerFastSeekSpeedRatio = 4;
            this.videoGrabber1.PlayerFileName = "";
            this.videoGrabber1.PlayerForcedCodec = "";
            this.videoGrabber1.PlayerHwAccel = VidGrab.THwAccel.hw_None;
            this.videoGrabber1.PlayerRefreshPausedDisplay = false;
            this.videoGrabber1.PlayerRefreshPausedDisplayFrameRate = 0D;
            this.videoGrabber1.PlayerSpeedRatio = 1D;
            this.videoGrabber1.PlayerSpeedRatioConstantAudioPitch = true;
            this.videoGrabber1.PlayerTrackBarSynchrone = false;
            this.videoGrabber1.PreallocCapFileCopiedAfterRecording = true;
            this.videoGrabber1.PreallocCapFileEnabled = false;
            this.videoGrabber1.PreallocCapFileName = "";
            this.videoGrabber1.PreallocCapFileSizeInMB = 100;
            this.videoGrabber1.PreviewZoomSize = 100;
            this.videoGrabber1.QuickDeviceInitialization = false;
            this.videoGrabber1.RawAudioSampleCapture = false;
            this.videoGrabber1.RawCaptureAsyncEvent = true;
            this.videoGrabber1.RawSampleCaptureLocation = VidGrab.TRawSampleCaptureLocation.rl_SourceFormat;
            this.videoGrabber1.RawVideoSampleCapture = false;
            this.videoGrabber1.RecordingAudioBitRate = -1;
            this.videoGrabber1.RecordingFileName = "";
            this.videoGrabber1.RecordingFileSizeMaxInMB = 0;
            this.videoGrabber1.RecordingInNativeFormat = true;
            this.videoGrabber1.RecordingMethod = VidGrab.TRecordingMethod.rm_MP4;
            this.videoGrabber1.RecordingOnMotion_Enabled = false;
            this.videoGrabber1.RecordingOnMotion_MotionThreshold = 0D;
            this.videoGrabber1.RecordingOnMotion_NoMotionPauseDelayMs = 5000;
            this.videoGrabber1.RecordingPauseCreatesNewFile = false;
            this.videoGrabber1.RecordingSize = VidGrab.TRecordingSize.rs_Default;
            this.videoGrabber1.RecordingTimer = VidGrab.TRecordingTimer.rt_Disabled;
            this.videoGrabber1.RecordingTimerInterval = 60;
            this.videoGrabber1.RecordingVideoBitRate = -1;
            this.videoGrabber1.Reencoding_IncludeAudioStream = true;
            this.videoGrabber1.Reencoding_IncludeVideoStream = true;
            this.videoGrabber1.Reencoding_Method = VidGrab.TRecordingMethod.rm_ASF;
            this.videoGrabber1.Reencoding_NewVideoClip = "";
            this.videoGrabber1.Reencoding_SourceVideoClip = "";
            this.videoGrabber1.Reencoding_StartFrame = ((long)(-1));
            this.videoGrabber1.Reencoding_StartTime = ((long)(-1));
            this.videoGrabber1.Reencoding_StopFrame = ((long)(-1));
            this.videoGrabber1.Reencoding_StopTime = ((long)(-1));
            this.videoGrabber1.Reencoding_UseAudioCompressor = false;
            this.videoGrabber1.Reencoding_UseFrameGrabber = true;
            this.videoGrabber1.Reencoding_UseVideoCompressor = false;
            this.videoGrabber1.Reencoding_WMVOutput = false;
            this.videoGrabber1.ScreenRecordingLayeredWindows = false;
            this.videoGrabber1.ScreenRecordingMonitor = 0;
            this.videoGrabber1.ScreenRecordingNonVisibleWindows = false;
            this.videoGrabber1.ScreenRecordingSizePercent = 100;
            this.videoGrabber1.ScreenRecordingThroughClipboard = false;
            this.videoGrabber1.ScreenRecordingWithCursor = true;
            this.videoGrabber1.Size = new System.Drawing.Size(299, 183);
            this.videoGrabber1.SpeakerControl = false;
            this.videoGrabber1.StoragePath = "C:\\Users\\win11\\AppData\\Local\\Temp\\";
            this.videoGrabber1.StoragePathMode = VidGrab.TStoragePathMode.spm_AutoFileNameOnly;
            this.videoGrabber1.StoreDeviceSettingsInRegistry = true;
            this.videoGrabber1.StreamInterface_Format = "";
            this.videoGrabber1.StreamInterface_FrameRate = 0D;
            this.videoGrabber1.StreamInterface_IsRealTime = true;
            this.videoGrabber1.SyncCommands = true;
            this.videoGrabber1.SynchronizationRole = VidGrab.TSynchronizationRole.sr_Master;
            this.videoGrabber1.Synchronized = false;
            this.videoGrabber1.SyncPreview = VidGrab.TSyncPreview.sp_Auto;
            this.videoGrabber1.TabIndex = 66;
            this.videoGrabber1.TextOverlay_Align = VidGrab.TTextOverlayAlign.tf_Left;
            this.videoGrabber1.TextOverlay_AlphaBlend = false;
            this.videoGrabber1.TextOverlay_AlphaBlendValue = 180;
            this.videoGrabber1.TextOverlay_BkColor = 16777215;
            this.videoGrabber1.TextOverlay_Enabled = false;
// TODO: '기본 형식이 잘못되었습니다. System.IntPtr. CodeObjectCreateExpression을 사용하십시오.' 예외가 발생하여 ''의 코드를 생성하지 못했습니다.
            this.videoGrabber1.TextOverlay_FontColor = 16776960;
            this.videoGrabber1.TextOverlay_FontSize = 12;
            this.videoGrabber1.TextOverlay_GradientColor = 8388608;
            this.videoGrabber1.TextOverlay_GradientMode = VidGrab.TTextOverlayGradientMode.gm_Disabled;
            this.videoGrabber1.TextOverlay_HighResFont = true;
            this.videoGrabber1.TextOverlay_Left = 0;
            this.videoGrabber1.TextOverlay_Orientation = VidGrab.TTextOrientation.to_Horizontal;
            this.videoGrabber1.TextOverlay_Right = -1;
            this.videoGrabber1.TextOverlay_Scrolling = false;
            this.videoGrabber1.TextOverlay_ScrollingSpeed = 1;
            this.videoGrabber1.TextOverlay_Shadow = true;
            this.videoGrabber1.TextOverlay_ShadowColor = 0;
            this.videoGrabber1.TextOverlay_ShadowDirection = VidGrab.TCardinalDirection.cd_SouthEast;
            this.videoGrabber1.TextOverlay_String = resources.GetString("videoGrabber1.TextOverlay_String");
            this.videoGrabber1.TextOverlay_TargetDisplay = -1;
            this.videoGrabber1.TextOverlay_Top = 0;
            this.videoGrabber1.TextOverlay_Transparent = true;
            this.videoGrabber1.TextOverlay_VideoAlignment = VidGrab.TVideoAlignment.oa_LeftTop;
            this.videoGrabber1.ThirdPartyDeinterlacer = "";
            this.videoGrabber1.TranslateMouseCoordinates = true;
            this.videoGrabber1.TunerFrequency = -1;
            this.videoGrabber1.TVUseFrequencyOverrides = false;
            this.videoGrabber1.UseClock = true;
            this.videoGrabber1.v360_AspectRatio = 0D;
            this.videoGrabber1.v360_Enabled = false;
            this.videoGrabber1.v360_MasterAngle = VidGrab.Tv360_Angle.v360_fov_Horizontal;
            this.videoGrabber1.v360_MouseAction = VidGrab.TV360_MouseAction.ma_MouseMove;
            this.videoGrabber1.v360_MouseActionPercent = 10;
            this.videoGrabber1.Version = "v16.1.1.8 (build 5262.250416) - Copyright © 2025 Datastead";
            this.videoGrabber1.VideoCompression_DataRate = -1;
            this.videoGrabber1.VideoCompression_KeyFrameRate = 15;
            this.videoGrabber1.VideoCompression_PFramesPerKeyFrame = 0;
            this.videoGrabber1.VideoCompression_Quality = 1D;
            this.videoGrabber1.VideoCompression_WindowSize = -1;
            this.videoGrabber1.VideoCompressor = 0;
            this.videoGrabber1.VideoControlSettings = true;
            this.videoGrabber1.VideoCursor = VidGrab.TCursors.cr_Default;
            this.videoGrabber1.VideoDelay = ((long)(0));
            this.videoGrabber1.VideoDevice = -1;
            this.videoGrabber1.VideoFormat = -1;
            this.videoGrabber1.VideoFromImages_BitmapsSortedBy = VidGrab.TFileSort.fs_TimeAsc;
            this.videoGrabber1.VideoFromImages_RepeatIndefinitely = false;
            this.videoGrabber1.VideoFromImages_SourceDirectory = "C:\\Users\\win11\\AppData\\Local\\Temp\\";
            this.videoGrabber1.VideoFromImages_TemporaryFile = "SetOfBitmaps01.dat";
            this.videoGrabber1.VideoInput = -1;
            this.videoGrabber1.VideoProcessing_Brightness = 0;
            this.videoGrabber1.VideoProcessing_Contrast = 0;
            this.videoGrabber1.VideoProcessing_Deinterlacing = VidGrab.TVideoDeinterlacing.di_Disabled;
            this.videoGrabber1.VideoProcessing_FlipHorizontal = false;
            this.videoGrabber1.VideoProcessing_FlipVertical = false;
            this.videoGrabber1.VideoProcessing_GrayScale = false;
            this.videoGrabber1.VideoProcessing_Hue = 0;
            this.videoGrabber1.VideoProcessing_InvertColors = false;
            this.videoGrabber1.VideoProcessing_Pixellization = 1;
            this.videoGrabber1.VideoProcessing_Rotation = VidGrab.TVideoRotation.rt_0_deg;
            this.videoGrabber1.VideoProcessing_RotationCustomAngle = 45.5D;
            this.videoGrabber1.VideoProcessing_Saturation = 0;
            this.videoGrabber1.VideoQualitySettings = true;
            this.videoGrabber1.VideoRenderer = VidGrab.TVideoRenderer.vr_AutoSelect;
            this.videoGrabber1.VideoRendererExternal = VidGrab.TVideoRendererExternal.vre_None;
            this.videoGrabber1.VideoRendererExternalIndex = -1;
            this.videoGrabber1.VideoRendererPriority = VidGrab.TVideoRendererPriority.vrp_Auto;
            this.videoGrabber1.VideoSize = -1;
            this.videoGrabber1.VideoSource = VidGrab.TVideoSource.vs_VideoCaptureDevice;
            this.videoGrabber1.VideoSource_FileOrURL = "";
            this.videoGrabber1.VideoSource_FileOrURL_StartTime = ((long)(-1));
            this.videoGrabber1.VideoSource_FileOrURL_StopTime = ((long)(-1));
            this.videoGrabber1.VideoStreamNumber = -1;
            this.videoGrabber1.VideoSubtype = -1;
            this.videoGrabber1.VideoVisibleWhenStopped = false;
            this.videoGrabber1.VirtualAudioStreamControl = -1;
            this.videoGrabber1.VirtualVideoStreamControl = -1;
            this.videoGrabber1.VuMeter = VidGrab.TVuMeter.vu_Disabled;
            this.videoGrabber1.WebcamStillCaptureButton = VidGrab.TWebcamStillCaptureButton.wb_Disabled;
            this.videoGrabber1.ZoomCoeff = 1000;
            this.videoGrabber1.ZoomXCenter = 0;
            this.videoGrabber1.ZoomYCenter = 0;
            // 
            // videoGrabber2
            // 
            this.videoGrabber2.AdjustOverlayAspectRatio = true;
            this.videoGrabber2.AdjustPixelAspectRatio = true;
            this.videoGrabber2.Aero = VidGrab.TAero.ae_Default;
            this.videoGrabber2.AnalogVideoStandard = -1;
            this.videoGrabber2.ApplicationPriority = VidGrab.TApplicationPriority.ap_default;
            this.videoGrabber2.ASFAudioBitRate = -1;
            this.videoGrabber2.ASFAudioChannels = -1;
            this.videoGrabber2.ASFBufferWindow = -1;
            this.videoGrabber2.ASFDeinterlaceMode = VidGrab.TASFDeinterlaceMode.adm_NotInterlaced;
            this.videoGrabber2.ASFDirectStreamingKeepClientsConnected = false;
            this.videoGrabber2.ASFFixedFrameRate = true;
            this.videoGrabber2.ASFMediaServerPublishingPoint = "";
            this.videoGrabber2.ASFMediaServerRemovePublishingPointAfterDisconnect = false;
            this.videoGrabber2.ASFMediaServerTemplatePublishingPoint = "";
            this.videoGrabber2.ASFNetworkMaxUsers = 5;
            this.videoGrabber2.ASFNetworkPort = 0;
            this.videoGrabber2.ASFProfile = -1;
            this.videoGrabber2.ASFProfileFromCustomFile = "";
            this.videoGrabber2.ASFProfileVersion = VidGrab.TASFProfileVersion.apv_ProfileVersion_8;
            this.videoGrabber2.ASFVideoBitRate = -1;
            this.videoGrabber2.ASFVideoFrameRate = 0D;
            this.videoGrabber2.ASFVideoHeight = -1;
            this.videoGrabber2.ASFVideoMaxKeyFrameSpacing = -1;
            this.videoGrabber2.ASFVideoQuality = -1;
            this.videoGrabber2.ASFVideoWidth = -1;
            this.videoGrabber2.AspectRatioToUse = -1D;
            this.videoGrabber2.AssociateAudioAndVideoDevices = false;
            this.videoGrabber2.AudioChannelRenderMode = VidGrab.TAudioChannelRenderMode.acrm_PassThru;
            this.videoGrabber2.AudioCompressor = 0;
            this.videoGrabber2.AudioDevice = -1;
            this.videoGrabber2.AudioDeviceRendering = false;
            this.videoGrabber2.AudioFormat = VidGrab.TAudioFormat.af_default;
            this.videoGrabber2.AudioInput = -1;
            this.videoGrabber2.AudioPeakEvent = true;
            this.videoGrabber2.AudioRecording = false;
            this.videoGrabber2.AudioRenderer = -1;
            this.videoGrabber2.AudioSource = VidGrab.TAudioSource.as_Default;
            this.videoGrabber2.AudioStreamNumber = -1;
            this.videoGrabber2.AudioSyncAdjustment = 0;
            this.videoGrabber2.AudioSyncAdjustmentEnabled = false;
            this.videoGrabber2.AutoConnectRelatedPins = true;
            this.videoGrabber2.AutoFileName = VidGrab.TAutoFileName.fn_Sequential;
            this.videoGrabber2.AutoFileNameDateTimeFormat = "yymmdd_hhmmss_zzz";
            this.videoGrabber2.AutoFileNameMinDigits = 6;
            this.videoGrabber2.AutoFilePrefix = "vg";
            this.videoGrabber2.AutoFileSuffix = "";
            this.videoGrabber2.AutoRefreshPreview = false;
            this.videoGrabber2.AutoStartPlayer = true;
            this.videoGrabber2.AVIDurationUpdated = true;
            this.videoGrabber2.AVIFormatOpenDML = true;
            this.videoGrabber2.AVIFormatOpenDMLCompatibilityIndex = true;
            this.videoGrabber2.BackgroundColor = 0;
            this.videoGrabber2.BurstCount = 3;
            this.videoGrabber2.BurstInterval = 0;
            this.videoGrabber2.BurstMode = false;
            this.videoGrabber2.BurstType = VidGrab.TFrameCaptureDest.fc_TBitmap;
            this.videoGrabber2.BusyCursor = VidGrab.TCursors.cr_HourGlass;
            this.videoGrabber2.CameraControlSettings = true;
            this.videoGrabber2.CaptureFileExt = "";
            this.videoGrabber2.ColorKey = 1048592;
            this.videoGrabber2.ColorKeyEnabled = false;
            this.videoGrabber2.CompressionMode = VidGrab.TCompressionMode.cm_CompressOnTheFly;
            this.videoGrabber2.CompressionType = VidGrab.TCompressionType.ct_Video;
            this.videoGrabber2.Cropping_Enabled = false;
            this.videoGrabber2.Cropping_Height = 120;
            this.videoGrabber2.Cropping_Outbounds = true;
            this.videoGrabber2.Cropping_Width = 160;
            this.videoGrabber2.Cropping_X = 0;
            this.videoGrabber2.Cropping_Y = 0;
            this.videoGrabber2.Cropping_Zoom = 1D;
            this.videoGrabber2.Display_Active = true;
            this.videoGrabber2.Display_AlphaBlendEnabled = false;
            this.videoGrabber2.Display_AlphaBlendValue = 180;
            this.videoGrabber2.Display_AspectRatio = VidGrab.TAspectRatio.ar_Box;
            this.videoGrabber2.Display_AutoSize = false;
            this.videoGrabber2.Display_Embedded = true;
            this.videoGrabber2.Display_Embedded_FitParent = false;
            this.videoGrabber2.Display_FullScreen = false;
            this.videoGrabber2.Display_Height = 720;
            this.videoGrabber2.Display_Left = 10;
            this.videoGrabber2.Display_Monitor = 0;
            this.videoGrabber2.Display_MouseMovesWindow = true;
            this.videoGrabber2.Display_PanScanRatio = 50;
            this.videoGrabber2.Display_StayOnTop = false;
            this.videoGrabber2.Display_Top = 10;
            this.videoGrabber2.Display_TransparentColorEnabled = false;
            this.videoGrabber2.Display_TransparentColorValue = 255;
            this.videoGrabber2.Display_VideoPortEnabled = true;
            this.videoGrabber2.Display_Visible = true;
            this.videoGrabber2.Display_Width = 1280;
            this.videoGrabber2.DoubleBuffered = false;
            this.videoGrabber2.DroppedFramesPollingInterval = -1;
            this.videoGrabber2.DualDisplay_Active = false;
            this.videoGrabber2.DualDisplay_AlphaBlendEnabled = false;
            this.videoGrabber2.DualDisplay_AlphaBlendValue = 180;
            this.videoGrabber2.DualDisplay_AspectRatio = VidGrab.TAspectRatio.ar_Box;
            this.videoGrabber2.DualDisplay_AutoSize = false;
            this.videoGrabber2.DualDisplay_Embedded = false;
            this.videoGrabber2.DualDisplay_Embedded_FitParent = false;
            this.videoGrabber2.DualDisplay_FullScreen = false;
            this.videoGrabber2.DualDisplay_Height = 720;
            this.videoGrabber2.DualDisplay_Left = 20;
            this.videoGrabber2.DualDisplay_Monitor = 0;
            this.videoGrabber2.DualDisplay_MouseMovesWindow = true;
            this.videoGrabber2.DualDisplay_PanScanRatio = 50;
            this.videoGrabber2.DualDisplay_StayOnTop = false;
            this.videoGrabber2.DualDisplay_Top = 400;
            this.videoGrabber2.DualDisplay_TransparentColorEnabled = false;
            this.videoGrabber2.DualDisplay_TransparentColorValue = 255;
            this.videoGrabber2.DualDisplay_VideoPortEnabled = false;
            this.videoGrabber2.DualDisplay_Visible = true;
            this.videoGrabber2.DualDisplay_Width = 1280;
            this.videoGrabber2.DVDateTimeEnabled = true;
            this.videoGrabber2.DVDiscontinuityMinimumInterval = 3;
            this.videoGrabber2.DVDTitle = 0;
            this.videoGrabber2.DVEncoder_VideoFormat = VidGrab.TDVVideoFormat.dvf_DVSD;
            this.videoGrabber2.DVEncoder_VideoResolution = VidGrab.TDVSize.dv_Full;
            this.videoGrabber2.DVEncoder_VideoStandard = VidGrab.TDVVideoStandard.dvs_Default;
            this.videoGrabber2.DVRecordingInNativeFormatSeparatesStreams = false;
            this.videoGrabber2.DVReduceFrameRate = false;
            this.videoGrabber2.DVRgb219 = false;
            this.videoGrabber2.DVTimeCodeEnabled = false;
            this.videoGrabber2.EventNotificationSynchrone = true;
            this.videoGrabber2.ExtraDLLPath = "";
            this.videoGrabber2.FixFlickerOrBlackCapture = false;
            this.videoGrabber2.FrameCaptureHeight = -1;
            this.videoGrabber2.FrameCaptureWidth = -1;
            this.videoGrabber2.FrameCaptureWithoutOverlay = false;
            this.videoGrabber2.FrameCaptureZoomSize = 100;
            this.videoGrabber2.FrameGrabber = VidGrab.TFrameGrabber.fg_BothStreams;
            this.videoGrabber2.FrameGrabberRGBFormat = VidGrab.TFrameGrabberRGBFormat.fgf_Default;
            this.videoGrabber2.FrameNumberStartsFromZero = false;
            this.videoGrabber2.FrameRate = 0D;
            this.videoGrabber2.FrameRateDivider = 0;
            this.videoGrabber2.GeneratePts = false;
            this.videoGrabber2.GetLastFrameWaitTimeoutMs = 0;
            this.videoGrabber2.ImageOverlay_AlphaBlend = false;
            this.videoGrabber2.ImageOverlay_AlphaBlendValue = 180;
            this.videoGrabber2.ImageOverlay_ChromaKey = false;
            this.videoGrabber2.ImageOverlay_ChromaKeyLeewayPercent = 25;
            this.videoGrabber2.ImageOverlay_ChromaKeyRGBColor = 0;
            this.videoGrabber2.ImageOverlay_Height = -1;
            this.videoGrabber2.ImageOverlay_LeftLocation = 10;
            this.videoGrabber2.ImageOverlay_RotationAngle = 0D;
            this.videoGrabber2.ImageOverlay_StretchToVideoSize = false;
            this.videoGrabber2.ImageOverlay_TargetDisplay = -1;
            this.videoGrabber2.ImageOverlay_TopLocation = 10;
            this.videoGrabber2.ImageOverlay_Transparent = false;
            this.videoGrabber2.ImageOverlay_TransparentColorValue = 0;
            this.videoGrabber2.ImageOverlay_UseTransparentColor = false;
            this.videoGrabber2.ImageOverlay_VideoAlignment = VidGrab.TVideoAlignment.oa_LeftTop;
            this.videoGrabber2.ImageOverlay_Width = -1;
            this.videoGrabber2.ImageOverlayEnabled = false;
            this.videoGrabber2.IPCameraURL = "";
            this.videoGrabber2.JPEGPerformance = VidGrab.TJPEGPerformance.jpBestQuality;
            this.videoGrabber2.JPEGProgressiveDisplay = false;
            this.videoGrabber2.JPEGQuality = 100;
            this.videoGrabber2.LicenseString = "N/A";
            this.videoGrabber2.Location = new System.Drawing.Point(25, 124);
            this.videoGrabber2.LogoDisplayed = false;
            this.videoGrabber2.LogoLayout = VidGrab.TLogoLayout.lg_Stretched;
            this.videoGrabber2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.videoGrabber2.MixAudioSamples_CurrentSourceLevel = 100;
            this.videoGrabber2.MixAudioSamples_ExternalSourceLevel = 100;
            this.videoGrabber2.Mixer_MosaicColumns = 1;
            this.videoGrabber2.Mixer_MosaicLines = 1;
            this.videoGrabber2.MotionDetector_CompareBlue = true;
            this.videoGrabber2.MotionDetector_CompareGreen = true;
            this.videoGrabber2.MotionDetector_CompareRed = true;
            this.videoGrabber2.MotionDetector_Enabled = false;
            this.videoGrabber2.MotionDetector_GreyScale = false;
            this.videoGrabber2.MotionDetector_Grid = "5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555" +
    "555555 5555555555 5555555555";
            this.videoGrabber2.MotionDetector_MaxDetectionsPerSecond = 0D;
            this.videoGrabber2.MotionDetector_MotionResetMs = 0;
            this.videoGrabber2.MotionDetector_ReduceCPULoad = 1;
            this.videoGrabber2.MotionDetector_ReduceVideoNoise = false;
            this.videoGrabber2.MotionDetector_Triggered = false;
            this.videoGrabber2.MouseWheelControlsZoomAtCursor = false;
            this.videoGrabber2.MouseWheelEventEnabled = true;
            this.videoGrabber2.MultiplexedInputEmulation = true;
            this.videoGrabber2.MultiplexedRole = VidGrab.TMultiplexedRole.mr_NotMultiplexed;
            this.videoGrabber2.MultiplexedStabilizationDelay = 100;
            this.videoGrabber2.MultiplexedSwitchDelay = 0;
            this.videoGrabber2.Multiplexer = -1;
            this.videoGrabber2.MuteAudioRendering = false;
            this.videoGrabber2.Name = "videoGrabber2";
            this.videoGrabber2.NDIBandwidthType = VidGrab.TNDIBandwidthType.nbt_HighestBandwidth;
            this.videoGrabber2.NDIGroups = "";
            this.videoGrabber2.NDIName = "DATASTEAD_UNNAMED_SOURCE";
            this.videoGrabber2.NDIReceiveTimeoutMs = 5000;
            this.videoGrabber2.NetworkStreaming = VidGrab.TNetworkStreaming.ns_Disabled;
            this.videoGrabber2.NetworkStreamingType = VidGrab.TNetworkStreamingType.nst_AudioVideoStreaming;
            this.videoGrabber2.NormalCursor = VidGrab.TCursors.cr_Default;
            this.videoGrabber2.NotificationMethod = VidGrab.TNotificationMethod.nm_Thread;
            this.videoGrabber2.NotificationPriority = VidGrab.TThreadPriority.tpNormal;
            this.videoGrabber2.NotificationSleepTime = -1;
            this.videoGrabber2.OnFrameBitmapEventSynchrone = false;
            this.videoGrabber2.OpenURLAsync = true;
            this.videoGrabber2.OverlayAfterTransform = false;
            this.videoGrabber2.PlayerAudioRendering = true;
            this.videoGrabber2.PlayerDVSize = VidGrab.TDVSize.dv_Full;
            this.videoGrabber2.PlayerFastSeekSpeedRatio = 4;
            this.videoGrabber2.PlayerFileName = "";
            this.videoGrabber2.PlayerForcedCodec = "";
            this.videoGrabber2.PlayerHwAccel = VidGrab.THwAccel.hw_None;
            this.videoGrabber2.PlayerRefreshPausedDisplay = false;
            this.videoGrabber2.PlayerRefreshPausedDisplayFrameRate = 0D;
            this.videoGrabber2.PlayerSpeedRatio = 1D;
            this.videoGrabber2.PlayerSpeedRatioConstantAudioPitch = true;
            this.videoGrabber2.PlayerTrackBarSynchrone = false;
            this.videoGrabber2.PreallocCapFileCopiedAfterRecording = true;
            this.videoGrabber2.PreallocCapFileEnabled = false;
            this.videoGrabber2.PreallocCapFileName = "";
            this.videoGrabber2.PreallocCapFileSizeInMB = 100;
            this.videoGrabber2.PreviewZoomSize = 100;
            this.videoGrabber2.QuickDeviceInitialization = false;
            this.videoGrabber2.RawAudioSampleCapture = false;
            this.videoGrabber2.RawCaptureAsyncEvent = true;
            this.videoGrabber2.RawSampleCaptureLocation = VidGrab.TRawSampleCaptureLocation.rl_SourceFormat;
            this.videoGrabber2.RawVideoSampleCapture = false;
            this.videoGrabber2.RecordingAudioBitRate = -1;
            this.videoGrabber2.RecordingFileName = "";
            this.videoGrabber2.RecordingFileSizeMaxInMB = 0;
            this.videoGrabber2.RecordingInNativeFormat = true;
            this.videoGrabber2.RecordingMethod = VidGrab.TRecordingMethod.rm_MP4;
            this.videoGrabber2.RecordingOnMotion_Enabled = false;
            this.videoGrabber2.RecordingOnMotion_MotionThreshold = 0D;
            this.videoGrabber2.RecordingOnMotion_NoMotionPauseDelayMs = 5000;
            this.videoGrabber2.RecordingPauseCreatesNewFile = false;
            this.videoGrabber2.RecordingSize = VidGrab.TRecordingSize.rs_Default;
            this.videoGrabber2.RecordingTimer = VidGrab.TRecordingTimer.rt_Disabled;
            this.videoGrabber2.RecordingTimerInterval = 60;
            this.videoGrabber2.RecordingVideoBitRate = -1;
            this.videoGrabber2.Reencoding_IncludeAudioStream = true;
            this.videoGrabber2.Reencoding_IncludeVideoStream = true;
            this.videoGrabber2.Reencoding_Method = VidGrab.TRecordingMethod.rm_ASF;
            this.videoGrabber2.Reencoding_NewVideoClip = "";
            this.videoGrabber2.Reencoding_SourceVideoClip = "";
            this.videoGrabber2.Reencoding_StartFrame = ((long)(-1));
            this.videoGrabber2.Reencoding_StartTime = ((long)(-1));
            this.videoGrabber2.Reencoding_StopFrame = ((long)(-1));
            this.videoGrabber2.Reencoding_StopTime = ((long)(-1));
            this.videoGrabber2.Reencoding_UseAudioCompressor = false;
            this.videoGrabber2.Reencoding_UseFrameGrabber = true;
            this.videoGrabber2.Reencoding_UseVideoCompressor = false;
            this.videoGrabber2.Reencoding_WMVOutput = false;
            this.videoGrabber2.ScreenRecordingLayeredWindows = false;
            this.videoGrabber2.ScreenRecordingMonitor = 0;
            this.videoGrabber2.ScreenRecordingNonVisibleWindows = false;
            this.videoGrabber2.ScreenRecordingSizePercent = 100;
            this.videoGrabber2.ScreenRecordingThroughClipboard = false;
            this.videoGrabber2.ScreenRecordingWithCursor = true;
            this.videoGrabber2.Size = new System.Drawing.Size(514, 366);
            this.videoGrabber2.SpeakerControl = false;
            this.videoGrabber2.StoragePath = "C:\\Users\\win11\\AppData\\Local\\Temp\\";
            this.videoGrabber2.StoragePathMode = VidGrab.TStoragePathMode.spm_AutoFileNameOnly;
            this.videoGrabber2.StoreDeviceSettingsInRegistry = true;
            this.videoGrabber2.StreamInterface_Format = "";
            this.videoGrabber2.StreamInterface_FrameRate = 0D;
            this.videoGrabber2.StreamInterface_IsRealTime = true;
            this.videoGrabber2.SyncCommands = true;
            this.videoGrabber2.SynchronizationRole = VidGrab.TSynchronizationRole.sr_Master;
            this.videoGrabber2.Synchronized = false;
            this.videoGrabber2.SyncPreview = VidGrab.TSyncPreview.sp_Auto;
            this.videoGrabber2.TabIndex = 67;
            this.videoGrabber2.TextOverlay_Align = VidGrab.TTextOverlayAlign.tf_Left;
            this.videoGrabber2.TextOverlay_AlphaBlend = false;
            this.videoGrabber2.TextOverlay_AlphaBlendValue = 180;
            this.videoGrabber2.TextOverlay_BkColor = 16777215;
            this.videoGrabber2.TextOverlay_Enabled = false;
// TODO: '기본 형식이 잘못되었습니다. System.IntPtr. CodeObjectCreateExpression을 사용하십시오.' 예외가 발생하여 ''의 코드를 생성하지 못했습니다.
            this.videoGrabber2.TextOverlay_FontColor = 16776960;
            this.videoGrabber2.TextOverlay_FontSize = 12;
            this.videoGrabber2.TextOverlay_GradientColor = 8388608;
            this.videoGrabber2.TextOverlay_GradientMode = VidGrab.TTextOverlayGradientMode.gm_Disabled;
            this.videoGrabber2.TextOverlay_HighResFont = true;
            this.videoGrabber2.TextOverlay_Left = 0;
            this.videoGrabber2.TextOverlay_Orientation = VidGrab.TTextOrientation.to_Horizontal;
            this.videoGrabber2.TextOverlay_Right = -1;
            this.videoGrabber2.TextOverlay_Scrolling = false;
            this.videoGrabber2.TextOverlay_ScrollingSpeed = 1;
            this.videoGrabber2.TextOverlay_Shadow = true;
            this.videoGrabber2.TextOverlay_ShadowColor = 0;
            this.videoGrabber2.TextOverlay_ShadowDirection = VidGrab.TCardinalDirection.cd_SouthEast;
            this.videoGrabber2.TextOverlay_String = resources.GetString("videoGrabber2.TextOverlay_String");
            this.videoGrabber2.TextOverlay_TargetDisplay = -1;
            this.videoGrabber2.TextOverlay_Top = 0;
            this.videoGrabber2.TextOverlay_Transparent = true;
            this.videoGrabber2.TextOverlay_VideoAlignment = VidGrab.TVideoAlignment.oa_LeftTop;
            this.videoGrabber2.ThirdPartyDeinterlacer = "";
            this.videoGrabber2.TranslateMouseCoordinates = true;
            this.videoGrabber2.TunerFrequency = -1;
            this.videoGrabber2.TVUseFrequencyOverrides = false;
            this.videoGrabber2.UseClock = true;
            this.videoGrabber2.v360_AspectRatio = 0D;
            this.videoGrabber2.v360_Enabled = false;
            this.videoGrabber2.v360_MasterAngle = VidGrab.Tv360_Angle.v360_fov_Horizontal;
            this.videoGrabber2.v360_MouseAction = VidGrab.TV360_MouseAction.ma_MouseMove;
            this.videoGrabber2.v360_MouseActionPercent = 10;
            this.videoGrabber2.Version = "v16.1.1.8 (build 5262.250416) - Copyright © 2025 Datastead";
            this.videoGrabber2.VideoCompression_DataRate = -1;
            this.videoGrabber2.VideoCompression_KeyFrameRate = 15;
            this.videoGrabber2.VideoCompression_PFramesPerKeyFrame = 0;
            this.videoGrabber2.VideoCompression_Quality = 1D;
            this.videoGrabber2.VideoCompression_WindowSize = -1;
            this.videoGrabber2.VideoCompressor = 0;
            this.videoGrabber2.VideoControlSettings = true;
            this.videoGrabber2.VideoCursor = VidGrab.TCursors.cr_Default;
            this.videoGrabber2.VideoDelay = ((long)(0));
            this.videoGrabber2.VideoDevice = -1;
            this.videoGrabber2.VideoFormat = -1;
            this.videoGrabber2.VideoFromImages_BitmapsSortedBy = VidGrab.TFileSort.fs_TimeAsc;
            this.videoGrabber2.VideoFromImages_RepeatIndefinitely = false;
            this.videoGrabber2.VideoFromImages_SourceDirectory = "C:\\Users\\win11\\AppData\\Local\\Temp\\";
            this.videoGrabber2.VideoFromImages_TemporaryFile = "SetOfBitmaps01.dat";
            this.videoGrabber2.VideoInput = -1;
            this.videoGrabber2.VideoProcessing_Brightness = 0;
            this.videoGrabber2.VideoProcessing_Contrast = 0;
            this.videoGrabber2.VideoProcessing_Deinterlacing = VidGrab.TVideoDeinterlacing.di_Disabled;
            this.videoGrabber2.VideoProcessing_FlipHorizontal = false;
            this.videoGrabber2.VideoProcessing_FlipVertical = false;
            this.videoGrabber2.VideoProcessing_GrayScale = false;
            this.videoGrabber2.VideoProcessing_Hue = 0;
            this.videoGrabber2.VideoProcessing_InvertColors = false;
            this.videoGrabber2.VideoProcessing_Pixellization = 1;
            this.videoGrabber2.VideoProcessing_Rotation = VidGrab.TVideoRotation.rt_0_deg;
            this.videoGrabber2.VideoProcessing_RotationCustomAngle = 45.5D;
            this.videoGrabber2.VideoProcessing_Saturation = 0;
            this.videoGrabber2.VideoQualitySettings = true;
            this.videoGrabber2.VideoRenderer = VidGrab.TVideoRenderer.vr_AutoSelect;
            this.videoGrabber2.VideoRendererExternal = VidGrab.TVideoRendererExternal.vre_None;
            this.videoGrabber2.VideoRendererExternalIndex = -1;
            this.videoGrabber2.VideoRendererPriority = VidGrab.TVideoRendererPriority.vrp_Auto;
            this.videoGrabber2.VideoSize = -1;
            this.videoGrabber2.VideoSource = VidGrab.TVideoSource.vs_VideoCaptureDevice;
            this.videoGrabber2.VideoSource_FileOrURL = "";
            this.videoGrabber2.VideoSource_FileOrURL_StartTime = ((long)(-1));
            this.videoGrabber2.VideoSource_FileOrURL_StopTime = ((long)(-1));
            this.videoGrabber2.VideoStreamNumber = -1;
            this.videoGrabber2.VideoSubtype = -1;
            this.videoGrabber2.VideoVisibleWhenStopped = false;
            this.videoGrabber2.VirtualAudioStreamControl = -1;
            this.videoGrabber2.VirtualVideoStreamControl = -1;
            this.videoGrabber2.VuMeter = VidGrab.TVuMeter.vu_Disabled;
            this.videoGrabber2.WebcamStillCaptureButton = VidGrab.TWebcamStillCaptureButton.wb_Disabled;
            this.videoGrabber2.ZoomCoeff = 1000;
            this.videoGrabber2.ZoomXCenter = 0;
            this.videoGrabber2.ZoomYCenter = 0;
            // 
            // videoGrabber3
            // 
            this.videoGrabber3.AdjustOverlayAspectRatio = true;
            this.videoGrabber3.AdjustPixelAspectRatio = true;
            this.videoGrabber3.Aero = VidGrab.TAero.ae_Default;
            this.videoGrabber3.AnalogVideoStandard = -1;
            this.videoGrabber3.ApplicationPriority = VidGrab.TApplicationPriority.ap_default;
            this.videoGrabber3.ASFAudioBitRate = -1;
            this.videoGrabber3.ASFAudioChannels = -1;
            this.videoGrabber3.ASFBufferWindow = -1;
            this.videoGrabber3.ASFDeinterlaceMode = VidGrab.TASFDeinterlaceMode.adm_NotInterlaced;
            this.videoGrabber3.ASFDirectStreamingKeepClientsConnected = false;
            this.videoGrabber3.ASFFixedFrameRate = true;
            this.videoGrabber3.ASFMediaServerPublishingPoint = "";
            this.videoGrabber3.ASFMediaServerRemovePublishingPointAfterDisconnect = false;
            this.videoGrabber3.ASFMediaServerTemplatePublishingPoint = "";
            this.videoGrabber3.ASFNetworkMaxUsers = 5;
            this.videoGrabber3.ASFNetworkPort = 0;
            this.videoGrabber3.ASFProfile = -1;
            this.videoGrabber3.ASFProfileFromCustomFile = "";
            this.videoGrabber3.ASFProfileVersion = VidGrab.TASFProfileVersion.apv_ProfileVersion_8;
            this.videoGrabber3.ASFVideoBitRate = -1;
            this.videoGrabber3.ASFVideoFrameRate = 0D;
            this.videoGrabber3.ASFVideoHeight = -1;
            this.videoGrabber3.ASFVideoMaxKeyFrameSpacing = -1;
            this.videoGrabber3.ASFVideoQuality = -1;
            this.videoGrabber3.ASFVideoWidth = -1;
            this.videoGrabber3.AspectRatioToUse = -1D;
            this.videoGrabber3.AssociateAudioAndVideoDevices = false;
            this.videoGrabber3.AudioChannelRenderMode = VidGrab.TAudioChannelRenderMode.acrm_PassThru;
            this.videoGrabber3.AudioCompressor = 0;
            this.videoGrabber3.AudioDevice = -1;
            this.videoGrabber3.AudioDeviceRendering = false;
            this.videoGrabber3.AudioFormat = VidGrab.TAudioFormat.af_default;
            this.videoGrabber3.AudioInput = -1;
            this.videoGrabber3.AudioPeakEvent = true;
            this.videoGrabber3.AudioRecording = false;
            this.videoGrabber3.AudioRenderer = -1;
            this.videoGrabber3.AudioSource = VidGrab.TAudioSource.as_Default;
            this.videoGrabber3.AudioStreamNumber = -1;
            this.videoGrabber3.AudioSyncAdjustment = 0;
            this.videoGrabber3.AudioSyncAdjustmentEnabled = false;
            this.videoGrabber3.AutoConnectRelatedPins = true;
            this.videoGrabber3.AutoFileName = VidGrab.TAutoFileName.fn_Sequential;
            this.videoGrabber3.AutoFileNameDateTimeFormat = "yymmdd_hhmmss_zzz";
            this.videoGrabber3.AutoFileNameMinDigits = 6;
            this.videoGrabber3.AutoFilePrefix = "vg";
            this.videoGrabber3.AutoFileSuffix = "";
            this.videoGrabber3.AutoRefreshPreview = false;
            this.videoGrabber3.AutoStartPlayer = true;
            this.videoGrabber3.AVIDurationUpdated = true;
            this.videoGrabber3.AVIFormatOpenDML = true;
            this.videoGrabber3.AVIFormatOpenDMLCompatibilityIndex = true;
            this.videoGrabber3.BackgroundColor = 0;
            this.videoGrabber3.BurstCount = 3;
            this.videoGrabber3.BurstInterval = 0;
            this.videoGrabber3.BurstMode = false;
            this.videoGrabber3.BurstType = VidGrab.TFrameCaptureDest.fc_TBitmap;
            this.videoGrabber3.BusyCursor = VidGrab.TCursors.cr_HourGlass;
            this.videoGrabber3.CameraControlSettings = true;
            this.videoGrabber3.CaptureFileExt = "";
            this.videoGrabber3.ColorKey = 1048592;
            this.videoGrabber3.ColorKeyEnabled = false;
            this.videoGrabber3.CompressionMode = VidGrab.TCompressionMode.cm_CompressOnTheFly;
            this.videoGrabber3.CompressionType = VidGrab.TCompressionType.ct_Video;
            this.videoGrabber3.Cropping_Enabled = false;
            this.videoGrabber3.Cropping_Height = 120;
            this.videoGrabber3.Cropping_Outbounds = true;
            this.videoGrabber3.Cropping_Width = 160;
            this.videoGrabber3.Cropping_X = 0;
            this.videoGrabber3.Cropping_Y = 0;
            this.videoGrabber3.Cropping_Zoom = 1D;
            this.videoGrabber3.Display_Active = true;
            this.videoGrabber3.Display_AlphaBlendEnabled = false;
            this.videoGrabber3.Display_AlphaBlendValue = 180;
            this.videoGrabber3.Display_AspectRatio = VidGrab.TAspectRatio.ar_Box;
            this.videoGrabber3.Display_AutoSize = false;
            this.videoGrabber3.Display_Embedded = true;
            this.videoGrabber3.Display_Embedded_FitParent = false;
            this.videoGrabber3.Display_FullScreen = false;
            this.videoGrabber3.Display_Height = 720;
            this.videoGrabber3.Display_Left = 10;
            this.videoGrabber3.Display_Monitor = 0;
            this.videoGrabber3.Display_MouseMovesWindow = true;
            this.videoGrabber3.Display_PanScanRatio = 50;
            this.videoGrabber3.Display_StayOnTop = false;
            this.videoGrabber3.Display_Top = 10;
            this.videoGrabber3.Display_TransparentColorEnabled = false;
            this.videoGrabber3.Display_TransparentColorValue = 255;
            this.videoGrabber3.Display_VideoPortEnabled = true;
            this.videoGrabber3.Display_Visible = true;
            this.videoGrabber3.Display_Width = 1280;
            this.videoGrabber3.DoubleBuffered = false;
            this.videoGrabber3.DroppedFramesPollingInterval = -1;
            this.videoGrabber3.DualDisplay_Active = false;
            this.videoGrabber3.DualDisplay_AlphaBlendEnabled = false;
            this.videoGrabber3.DualDisplay_AlphaBlendValue = 180;
            this.videoGrabber3.DualDisplay_AspectRatio = VidGrab.TAspectRatio.ar_Box;
            this.videoGrabber3.DualDisplay_AutoSize = false;
            this.videoGrabber3.DualDisplay_Embedded = false;
            this.videoGrabber3.DualDisplay_Embedded_FitParent = false;
            this.videoGrabber3.DualDisplay_FullScreen = false;
            this.videoGrabber3.DualDisplay_Height = 720;
            this.videoGrabber3.DualDisplay_Left = 20;
            this.videoGrabber3.DualDisplay_Monitor = 0;
            this.videoGrabber3.DualDisplay_MouseMovesWindow = true;
            this.videoGrabber3.DualDisplay_PanScanRatio = 50;
            this.videoGrabber3.DualDisplay_StayOnTop = false;
            this.videoGrabber3.DualDisplay_Top = 400;
            this.videoGrabber3.DualDisplay_TransparentColorEnabled = false;
            this.videoGrabber3.DualDisplay_TransparentColorValue = 255;
            this.videoGrabber3.DualDisplay_VideoPortEnabled = false;
            this.videoGrabber3.DualDisplay_Visible = true;
            this.videoGrabber3.DualDisplay_Width = 1280;
            this.videoGrabber3.DVDateTimeEnabled = true;
            this.videoGrabber3.DVDiscontinuityMinimumInterval = 3;
            this.videoGrabber3.DVDTitle = 0;
            this.videoGrabber3.DVEncoder_VideoFormat = VidGrab.TDVVideoFormat.dvf_DVSD;
            this.videoGrabber3.DVEncoder_VideoResolution = VidGrab.TDVSize.dv_Full;
            this.videoGrabber3.DVEncoder_VideoStandard = VidGrab.TDVVideoStandard.dvs_Default;
            this.videoGrabber3.DVRecordingInNativeFormatSeparatesStreams = false;
            this.videoGrabber3.DVReduceFrameRate = false;
            this.videoGrabber3.DVRgb219 = false;
            this.videoGrabber3.DVTimeCodeEnabled = false;
            this.videoGrabber3.EventNotificationSynchrone = true;
            this.videoGrabber3.ExtraDLLPath = "";
            this.videoGrabber3.FixFlickerOrBlackCapture = false;
            this.videoGrabber3.FrameCaptureHeight = -1;
            this.videoGrabber3.FrameCaptureWidth = -1;
            this.videoGrabber3.FrameCaptureWithoutOverlay = false;
            this.videoGrabber3.FrameCaptureZoomSize = 100;
            this.videoGrabber3.FrameGrabber = VidGrab.TFrameGrabber.fg_BothStreams;
            this.videoGrabber3.FrameGrabberRGBFormat = VidGrab.TFrameGrabberRGBFormat.fgf_Default;
            this.videoGrabber3.FrameNumberStartsFromZero = false;
            this.videoGrabber3.FrameRate = 0D;
            this.videoGrabber3.FrameRateDivider = 0;
            this.videoGrabber3.GeneratePts = false;
            this.videoGrabber3.GetLastFrameWaitTimeoutMs = 0;
            this.videoGrabber3.ImageOverlay_AlphaBlend = false;
            this.videoGrabber3.ImageOverlay_AlphaBlendValue = 180;
            this.videoGrabber3.ImageOverlay_ChromaKey = false;
            this.videoGrabber3.ImageOverlay_ChromaKeyLeewayPercent = 25;
            this.videoGrabber3.ImageOverlay_ChromaKeyRGBColor = 0;
            this.videoGrabber3.ImageOverlay_Height = -1;
            this.videoGrabber3.ImageOverlay_LeftLocation = 10;
            this.videoGrabber3.ImageOverlay_RotationAngle = 0D;
            this.videoGrabber3.ImageOverlay_StretchToVideoSize = false;
            this.videoGrabber3.ImageOverlay_TargetDisplay = -1;
            this.videoGrabber3.ImageOverlay_TopLocation = 10;
            this.videoGrabber3.ImageOverlay_Transparent = false;
            this.videoGrabber3.ImageOverlay_TransparentColorValue = 0;
            this.videoGrabber3.ImageOverlay_UseTransparentColor = false;
            this.videoGrabber3.ImageOverlay_VideoAlignment = VidGrab.TVideoAlignment.oa_LeftTop;
            this.videoGrabber3.ImageOverlay_Width = -1;
            this.videoGrabber3.ImageOverlayEnabled = false;
            this.videoGrabber3.IPCameraURL = "";
            this.videoGrabber3.JPEGPerformance = VidGrab.TJPEGPerformance.jpBestQuality;
            this.videoGrabber3.JPEGProgressiveDisplay = false;
            this.videoGrabber3.JPEGQuality = 100;
            this.videoGrabber3.LicenseString = "N/A";
            this.videoGrabber3.Location = new System.Drawing.Point(695, 124);
            this.videoGrabber3.LogoDisplayed = false;
            this.videoGrabber3.LogoLayout = VidGrab.TLogoLayout.lg_Stretched;
            this.videoGrabber3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.videoGrabber3.MixAudioSamples_CurrentSourceLevel = 100;
            this.videoGrabber3.MixAudioSamples_ExternalSourceLevel = 100;
            this.videoGrabber3.Mixer_MosaicColumns = 1;
            this.videoGrabber3.Mixer_MosaicLines = 1;
            this.videoGrabber3.MotionDetector_CompareBlue = true;
            this.videoGrabber3.MotionDetector_CompareGreen = true;
            this.videoGrabber3.MotionDetector_CompareRed = true;
            this.videoGrabber3.MotionDetector_Enabled = false;
            this.videoGrabber3.MotionDetector_GreyScale = false;
            this.videoGrabber3.MotionDetector_Grid = "5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555" +
    "555555 5555555555 5555555555";
            this.videoGrabber3.MotionDetector_MaxDetectionsPerSecond = 0D;
            this.videoGrabber3.MotionDetector_MotionResetMs = 0;
            this.videoGrabber3.MotionDetector_ReduceCPULoad = 1;
            this.videoGrabber3.MotionDetector_ReduceVideoNoise = false;
            this.videoGrabber3.MotionDetector_Triggered = false;
            this.videoGrabber3.MouseWheelControlsZoomAtCursor = false;
            this.videoGrabber3.MouseWheelEventEnabled = true;
            this.videoGrabber3.MultiplexedInputEmulation = true;
            this.videoGrabber3.MultiplexedRole = VidGrab.TMultiplexedRole.mr_NotMultiplexed;
            this.videoGrabber3.MultiplexedStabilizationDelay = 100;
            this.videoGrabber3.MultiplexedSwitchDelay = 0;
            this.videoGrabber3.Multiplexer = -1;
            this.videoGrabber3.MuteAudioRendering = false;
            this.videoGrabber3.Name = "videoGrabber3";
            this.videoGrabber3.NDIBandwidthType = VidGrab.TNDIBandwidthType.nbt_HighestBandwidth;
            this.videoGrabber3.NDIGroups = "";
            this.videoGrabber3.NDIName = "DATASTEAD_UNNAMED_SOURCE";
            this.videoGrabber3.NDIReceiveTimeoutMs = 5000;
            this.videoGrabber3.NetworkStreaming = VidGrab.TNetworkStreaming.ns_Disabled;
            this.videoGrabber3.NetworkStreamingType = VidGrab.TNetworkStreamingType.nst_AudioVideoStreaming;
            this.videoGrabber3.NormalCursor = VidGrab.TCursors.cr_Default;
            this.videoGrabber3.NotificationMethod = VidGrab.TNotificationMethod.nm_Thread;
            this.videoGrabber3.NotificationPriority = VidGrab.TThreadPriority.tpNormal;
            this.videoGrabber3.NotificationSleepTime = -1;
            this.videoGrabber3.OnFrameBitmapEventSynchrone = false;
            this.videoGrabber3.OpenURLAsync = true;
            this.videoGrabber3.OverlayAfterTransform = false;
            this.videoGrabber3.PlayerAudioRendering = true;
            this.videoGrabber3.PlayerDVSize = VidGrab.TDVSize.dv_Full;
            this.videoGrabber3.PlayerFastSeekSpeedRatio = 4;
            this.videoGrabber3.PlayerFileName = "";
            this.videoGrabber3.PlayerForcedCodec = "";
            this.videoGrabber3.PlayerHwAccel = VidGrab.THwAccel.hw_None;
            this.videoGrabber3.PlayerRefreshPausedDisplay = false;
            this.videoGrabber3.PlayerRefreshPausedDisplayFrameRate = 0D;
            this.videoGrabber3.PlayerSpeedRatio = 1D;
            this.videoGrabber3.PlayerSpeedRatioConstantAudioPitch = true;
            this.videoGrabber3.PlayerTrackBarSynchrone = false;
            this.videoGrabber3.PreallocCapFileCopiedAfterRecording = true;
            this.videoGrabber3.PreallocCapFileEnabled = false;
            this.videoGrabber3.PreallocCapFileName = "";
            this.videoGrabber3.PreallocCapFileSizeInMB = 100;
            this.videoGrabber3.PreviewZoomSize = 100;
            this.videoGrabber3.QuickDeviceInitialization = false;
            this.videoGrabber3.RawAudioSampleCapture = false;
            this.videoGrabber3.RawCaptureAsyncEvent = true;
            this.videoGrabber3.RawSampleCaptureLocation = VidGrab.TRawSampleCaptureLocation.rl_SourceFormat;
            this.videoGrabber3.RawVideoSampleCapture = false;
            this.videoGrabber3.RecordingAudioBitRate = -1;
            this.videoGrabber3.RecordingFileName = "";
            this.videoGrabber3.RecordingFileSizeMaxInMB = 0;
            this.videoGrabber3.RecordingInNativeFormat = true;
            this.videoGrabber3.RecordingMethod = VidGrab.TRecordingMethod.rm_MP4;
            this.videoGrabber3.RecordingOnMotion_Enabled = false;
            this.videoGrabber3.RecordingOnMotion_MotionThreshold = 0D;
            this.videoGrabber3.RecordingOnMotion_NoMotionPauseDelayMs = 5000;
            this.videoGrabber3.RecordingPauseCreatesNewFile = false;
            this.videoGrabber3.RecordingSize = VidGrab.TRecordingSize.rs_Default;
            this.videoGrabber3.RecordingTimer = VidGrab.TRecordingTimer.rt_Disabled;
            this.videoGrabber3.RecordingTimerInterval = 60;
            this.videoGrabber3.RecordingVideoBitRate = -1;
            this.videoGrabber3.Reencoding_IncludeAudioStream = true;
            this.videoGrabber3.Reencoding_IncludeVideoStream = true;
            this.videoGrabber3.Reencoding_Method = VidGrab.TRecordingMethod.rm_ASF;
            this.videoGrabber3.Reencoding_NewVideoClip = "";
            this.videoGrabber3.Reencoding_SourceVideoClip = "";
            this.videoGrabber3.Reencoding_StartFrame = ((long)(-1));
            this.videoGrabber3.Reencoding_StartTime = ((long)(-1));
            this.videoGrabber3.Reencoding_StopFrame = ((long)(-1));
            this.videoGrabber3.Reencoding_StopTime = ((long)(-1));
            this.videoGrabber3.Reencoding_UseAudioCompressor = false;
            this.videoGrabber3.Reencoding_UseFrameGrabber = true;
            this.videoGrabber3.Reencoding_UseVideoCompressor = false;
            this.videoGrabber3.Reencoding_WMVOutput = false;
            this.videoGrabber3.ScreenRecordingLayeredWindows = false;
            this.videoGrabber3.ScreenRecordingMonitor = 0;
            this.videoGrabber3.ScreenRecordingNonVisibleWindows = false;
            this.videoGrabber3.ScreenRecordingSizePercent = 100;
            this.videoGrabber3.ScreenRecordingThroughClipboard = false;
            this.videoGrabber3.ScreenRecordingWithCursor = true;
            this.videoGrabber3.Size = new System.Drawing.Size(498, 366);
            this.videoGrabber3.SpeakerControl = false;
            this.videoGrabber3.StoragePath = "C:\\Users\\win11\\AppData\\Local\\Temp\\";
            this.videoGrabber3.StoragePathMode = VidGrab.TStoragePathMode.spm_AutoFileNameOnly;
            this.videoGrabber3.StoreDeviceSettingsInRegistry = true;
            this.videoGrabber3.StreamInterface_Format = "";
            this.videoGrabber3.StreamInterface_FrameRate = 0D;
            this.videoGrabber3.StreamInterface_IsRealTime = true;
            this.videoGrabber3.SyncCommands = true;
            this.videoGrabber3.SynchronizationRole = VidGrab.TSynchronizationRole.sr_Master;
            this.videoGrabber3.Synchronized = false;
            this.videoGrabber3.SyncPreview = VidGrab.TSyncPreview.sp_Auto;
            this.videoGrabber3.TabIndex = 68;
            this.videoGrabber3.TextOverlay_Align = VidGrab.TTextOverlayAlign.tf_Left;
            this.videoGrabber3.TextOverlay_AlphaBlend = false;
            this.videoGrabber3.TextOverlay_AlphaBlendValue = 180;
            this.videoGrabber3.TextOverlay_BkColor = 16777215;
            this.videoGrabber3.TextOverlay_Enabled = false;
// TODO: '기본 형식이 잘못되었습니다. System.IntPtr. CodeObjectCreateExpression을 사용하십시오.' 예외가 발생하여 ''의 코드를 생성하지 못했습니다.
            this.videoGrabber3.TextOverlay_FontColor = 16776960;
            this.videoGrabber3.TextOverlay_FontSize = 12;
            this.videoGrabber3.TextOverlay_GradientColor = 8388608;
            this.videoGrabber3.TextOverlay_GradientMode = VidGrab.TTextOverlayGradientMode.gm_Disabled;
            this.videoGrabber3.TextOverlay_HighResFont = true;
            this.videoGrabber3.TextOverlay_Left = 0;
            this.videoGrabber3.TextOverlay_Orientation = VidGrab.TTextOrientation.to_Horizontal;
            this.videoGrabber3.TextOverlay_Right = -1;
            this.videoGrabber3.TextOverlay_Scrolling = false;
            this.videoGrabber3.TextOverlay_ScrollingSpeed = 1;
            this.videoGrabber3.TextOverlay_Shadow = true;
            this.videoGrabber3.TextOverlay_ShadowColor = 0;
            this.videoGrabber3.TextOverlay_ShadowDirection = VidGrab.TCardinalDirection.cd_SouthEast;
            this.videoGrabber3.TextOverlay_String = resources.GetString("videoGrabber3.TextOverlay_String");
            this.videoGrabber3.TextOverlay_TargetDisplay = -1;
            this.videoGrabber3.TextOverlay_Top = 0;
            this.videoGrabber3.TextOverlay_Transparent = true;
            this.videoGrabber3.TextOverlay_VideoAlignment = VidGrab.TVideoAlignment.oa_LeftTop;
            this.videoGrabber3.ThirdPartyDeinterlacer = "";
            this.videoGrabber3.TranslateMouseCoordinates = true;
            this.videoGrabber3.TunerFrequency = -1;
            this.videoGrabber3.TVUseFrequencyOverrides = false;
            this.videoGrabber3.UseClock = true;
            this.videoGrabber3.v360_AspectRatio = 0D;
            this.videoGrabber3.v360_Enabled = false;
            this.videoGrabber3.v360_MasterAngle = VidGrab.Tv360_Angle.v360_fov_Horizontal;
            this.videoGrabber3.v360_MouseAction = VidGrab.TV360_MouseAction.ma_MouseMove;
            this.videoGrabber3.v360_MouseActionPercent = 10;
            this.videoGrabber3.Version = "v16.1.1.8 (build 5262.250416) - Copyright © 2025 Datastead";
            this.videoGrabber3.VideoCompression_DataRate = -1;
            this.videoGrabber3.VideoCompression_KeyFrameRate = 15;
            this.videoGrabber3.VideoCompression_PFramesPerKeyFrame = 0;
            this.videoGrabber3.VideoCompression_Quality = 1D;
            this.videoGrabber3.VideoCompression_WindowSize = -1;
            this.videoGrabber3.VideoCompressor = 0;
            this.videoGrabber3.VideoControlSettings = true;
            this.videoGrabber3.VideoCursor = VidGrab.TCursors.cr_Default;
            this.videoGrabber3.VideoDelay = ((long)(0));
            this.videoGrabber3.VideoDevice = -1;
            this.videoGrabber3.VideoFormat = -1;
            this.videoGrabber3.VideoFromImages_BitmapsSortedBy = VidGrab.TFileSort.fs_TimeAsc;
            this.videoGrabber3.VideoFromImages_RepeatIndefinitely = false;
            this.videoGrabber3.VideoFromImages_SourceDirectory = "C:\\Users\\win11\\AppData\\Local\\Temp\\";
            this.videoGrabber3.VideoFromImages_TemporaryFile = "SetOfBitmaps01.dat";
            this.videoGrabber3.VideoInput = -1;
            this.videoGrabber3.VideoProcessing_Brightness = 0;
            this.videoGrabber3.VideoProcessing_Contrast = 0;
            this.videoGrabber3.VideoProcessing_Deinterlacing = VidGrab.TVideoDeinterlacing.di_Disabled;
            this.videoGrabber3.VideoProcessing_FlipHorizontal = false;
            this.videoGrabber3.VideoProcessing_FlipVertical = false;
            this.videoGrabber3.VideoProcessing_GrayScale = false;
            this.videoGrabber3.VideoProcessing_Hue = 0;
            this.videoGrabber3.VideoProcessing_InvertColors = false;
            this.videoGrabber3.VideoProcessing_Pixellization = 1;
            this.videoGrabber3.VideoProcessing_Rotation = VidGrab.TVideoRotation.rt_0_deg;
            this.videoGrabber3.VideoProcessing_RotationCustomAngle = 45.5D;
            this.videoGrabber3.VideoProcessing_Saturation = 0;
            this.videoGrabber3.VideoQualitySettings = true;
            this.videoGrabber3.VideoRenderer = VidGrab.TVideoRenderer.vr_AutoSelect;
            this.videoGrabber3.VideoRendererExternal = VidGrab.TVideoRendererExternal.vre_None;
            this.videoGrabber3.VideoRendererExternalIndex = -1;
            this.videoGrabber3.VideoRendererPriority = VidGrab.TVideoRendererPriority.vrp_Auto;
            this.videoGrabber3.VideoSize = -1;
            this.videoGrabber3.VideoSource = VidGrab.TVideoSource.vs_VideoCaptureDevice;
            this.videoGrabber3.VideoSource_FileOrURL = "";
            this.videoGrabber3.VideoSource_FileOrURL_StartTime = ((long)(-1));
            this.videoGrabber3.VideoSource_FileOrURL_StopTime = ((long)(-1));
            this.videoGrabber3.VideoStreamNumber = -1;
            this.videoGrabber3.VideoSubtype = -1;
            this.videoGrabber3.VideoVisibleWhenStopped = false;
            this.videoGrabber3.VirtualAudioStreamControl = -1;
            this.videoGrabber3.VirtualVideoStreamControl = -1;
            this.videoGrabber3.VuMeter = VidGrab.TVuMeter.vu_Disabled;
            this.videoGrabber3.WebcamStillCaptureButton = VidGrab.TWebcamStillCaptureButton.wb_Disabled;
            this.videoGrabber3.ZoomCoeff = 1000;
            this.videoGrabber3.ZoomXCenter = 0;
            this.videoGrabber3.ZoomYCenter = 0;
            // 
            // lbl_speed
            // 
            this.lbl_speed.AutoSize = true;
            this.lbl_speed.Location = new System.Drawing.Point(33, 756);
            this.lbl_speed.Name = "lbl_speed";
            this.lbl_speed.Size = new System.Drawing.Size(80, 15);
            this.lbl_speed.TabIndex = 69;
            this.lbl_speed.Text = "speed ratio";
            // 
            // speed_trackerBar
            // 
            this.speed_trackerBar.Location = new System.Drawing.Point(116, 746);
            this.speed_trackerBar.Maximum = 1000;
            this.speed_trackerBar.Name = "speed_trackerBar";
            this.speed_trackerBar.Size = new System.Drawing.Size(110, 56);
            this.speed_trackerBar.TabIndex = 70;
            this.speed_trackerBar.Value = 500;
            this.speed_trackerBar.Scroll += new System.EventHandler(this.speed_trackerBar_Scroll);
            // 
            // lbl_duration
            // 
            this.lbl_duration.AutoSize = true;
            this.lbl_duration.Location = new System.Drawing.Point(32, 795);
            this.lbl_duration.Name = "lbl_duration";
            this.lbl_duration.Size = new System.Drawing.Size(170, 19);
            this.lbl_duration.TabIndex = 71;
            this.lbl_duration.Text = "move duration (ms)";
            // 
            // txt_duration
            // 
            this.txt_duration.Location = new System.Drawing.Point(176, 792);
            this.txt_duration.Name = "txt_duration";
            this.txt_duration.Size = new System.Drawing.Size(69, 25);
            this.txt_duration.TabIndex = 72;
            this.txt_duration.TextChanged += new System.EventHandler(this.txt_duration_TextChanged);
            // 
            // btn_zoom_in
            // 
            this.btn_zoom_in.Location = new System.Drawing.Point(328, 753);
            this.btn_zoom_in.Name = "btn_zoom_in";
            this.btn_zoom_in.Size = new System.Drawing.Size(38, 26);
            this.btn_zoom_in.TabIndex = 73;
            this.btn_zoom_in.Text = "+";
            this.btn_zoom_in.UseVisualStyleBackColor = true;
            this.btn_zoom_in.Click += new System.EventHandler(this.btn_zoom_in_Click);
            this.btn_zoom_in.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_zoom_in_MouseDown);
            // 
            // btn_zoom_out
            // 
            this.btn_zoom_out.Location = new System.Drawing.Point(372, 753);
            this.btn_zoom_out.Name = "btn_zoom_out";
            this.btn_zoom_out.Size = new System.Drawing.Size(38, 26);
            this.btn_zoom_out.TabIndex = 74;
            this.btn_zoom_out.Text = "-";
            this.btn_zoom_out.UseVisualStyleBackColor = true;
            this.btn_zoom_out.Click += new System.EventHandler(this.btn_zoom_out_Click);
            this.btn_zoom_out.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_zoom_out_MouseDown);
            // 
            // lbl_relative_move
            // 
            this.lbl_relative_move.AutoSize = true;
            this.lbl_relative_move.Location = new System.Drawing.Point(276, 799);
            this.lbl_relative_move.Name = "lbl_relative_move";
            this.lbl_relative_move.Size = new System.Drawing.Size(118, 19);
            this.lbl_relative_move.TabIndex = 75;
            this.lbl_relative_move.Text = "relative move";
            // 
            // txt_relative_move
            // 
            this.txt_relative_move.Location = new System.Drawing.Point(384, 795);
            this.txt_relative_move.Name = "txt_relative_move";
            this.txt_relative_move.Size = new System.Drawing.Size(100, 25);
            this.txt_relative_move.TabIndex = 76;
            this.txt_relative_move.TextChanged += new System.EventHandler(this.txt_relative_move_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 833);
            this.Controls.Add(this.txt_relative_move);
            this.Controls.Add(this.lbl_relative_move);
            this.Controls.Add(this.btn_zoom_out);
            this.Controls.Add(this.btn_zoom_in);
            this.Controls.Add(this.txt_duration);
            this.Controls.Add(this.lbl_duration);
            this.Controls.Add(this.speed_trackerBar);
            this.Controls.Add(this.lbl_speed);
            this.Controls.Add(this.videoGrabber3);
            this.Controls.Add(this.videoGrabber2);
            this.Controls.Add(this.videoGrabber1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.numericUpDown5);
            this.Controls.Add(this.numericUpDown6);
            this.Controls.Add(this.trackBar4);
            this.Controls.Add(this.trackBar5);
            this.Controls.Add(this.trackBar6);
            this.Controls.Add(this.tilt_numeric);
            this.Controls.Add(this.pan_numeric);
            this.Controls.Add(this.tilt_trackerBar);
            this.Controls.Add(this.pan_trackerBar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_connect2);
            this.Controls.Add(this.btn_connect1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.txt_password2);
            this.Controls.Add(this.txt_port2);
            this.Controls.Add(this.txt_id2);
            this.Controls.Add(this.txt_ipAddress2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_password1);
            this.Controls.Add(this.txt_port1);
            this.Controls.Add(this.txt_id1);
            this.Controls.Add(this.txt_ipAddress1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btn_down);
            this.Controls.Add(this.btn_left);
            this.Controls.Add(this.btn_right);
            this.Controls.Add(this.btn_up);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pan_trackerBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tilt_trackerBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pan_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tilt_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speed_trackerBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_up;
        private System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.Button btn_down;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ipAddress1;
        private System.Windows.Forms.TextBox txt_id1;
        private System.Windows.Forms.TextBox txt_port1;
        private System.Windows.Forms.TextBox txt_password1;
        private System.Windows.Forms.TextBox txt_password2;
        private System.Windows.Forms.TextBox txt_port2;
        private System.Windows.Forms.TextBox txt_id2;
        private System.Windows.Forms.TextBox txt_ipAddress2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button btn_connect1;
        private System.Windows.Forms.Button btn_connect2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TrackBar pan_trackerBar;
        private System.Windows.Forms.TrackBar tilt_trackerBar;
        private System.Windows.Forms.NumericUpDown pan_numeric;
        private System.Windows.Forms.NumericUpDown tilt_numeric;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.TrackBar trackBar5;
        private System.Windows.Forms.TrackBar trackBar6;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private VidGrab.VideoGrabber videoGrabber1;
        private VidGrab.VideoGrabber videoGrabber2;
        private VidGrab.VideoGrabber videoGrabber3;
        private System.Windows.Forms.Label lbl_speed;
        private System.Windows.Forms.TrackBar speed_trackerBar;
        private System.Windows.Forms.Label lbl_duration;
        private System.Windows.Forms.TextBox txt_duration;
        private System.Windows.Forms.Button btn_zoom_in;
        private System.Windows.Forms.Button btn_zoom_out;
        private System.Windows.Forms.Label lbl_relative_move;
        private System.Windows.Forms.TextBox txt_relative_move;
    }
}

