namespace lot {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        public void Turn_On() {
            this.BeginInvoke(new Action(() => {
                this.lblStatus.Text = "On";
                this.pbHaha.Visible = true;
            }));
        }
        public void Turn_Off() {
            this.BeginInvoke(new Action(() => {
                this.lblStatus.Text = "Off";
                this.pbHaha.Visible = false;
            }));
        }
    }
}