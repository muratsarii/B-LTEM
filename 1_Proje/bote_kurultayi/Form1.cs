using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bote_kurultayi
{
    public partial class frmkurultay : Form
    {
        Animator animator;
        int sayac,sayac1, sayackonu=0;
        public frmkurultay()
        {
            InitializeComponent();
            animator = new Animator();
            timer.Interval = 1000;
            timer1.Interval = 1000;
        }
        private void btncikis_Click(object sender, EventArgs e)
        {
            if (!animator.isActive)
            {
                animator.activeRipple((Button)sender, Color.Red);
            }
            DialogResult cevap = MessageBox.Show("Çıkmak İstediğine Emein misin ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap==DialogResult.Yes)
            {
                Application.Exit();                
            }
        }
        //215;159
        //840; 600

        private void btnpcacma_Click(object sender, EventArgs e)
        {
            flspcacilma.Visible = true;
            flsfare.Visible = false;
            flsklavye.Visible = false;
            flsnedenbilisim.Visible = false;
            grbdonanim.Visible = false;
            grbyardim.Visible = false;
            // btnrpcacilisi 118;145 3;18
            if (!animator.isActive)
            {
                animator.activeRipple((Button)sender, Color.Goldenrod);
            }
            MessageBox.Show("Bilgisayar Açma Kullanımı Aşamasına Geçtiniz. Hoş Geldiniz. ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            flspcacilma.Movie = Application.StartupPath + "\\BilgisayarAcmaKonusu.swf";
            flspcacilma.Loop = false;
            flspcacilma.Play();
            timer.Start();
        }
        private void btnfare_Click(object sender, EventArgs e)
        {
            flspcacilma.Visible = false;
            flsfare.Visible = true;
            flsklavye.Visible = false;
            flsnedenbilisim.Visible = false;
            grbdonanim.Visible = false;
            grbyardim.Visible = false;
            if (!animator.isActive)
            {
                animator.activeRipple((Button)sender, Color.Goldenrod);
            }
            MessageBox.Show("Fare Kullanımı Aşamasına Geçtiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            flsfare.Movie = Application.StartupPath + "\\fareKonusu.swf";
            flsfare.Loop = false;
            flsfare.Play();
            timer.Start();
        }
        private void btnklavye_Click(object sender, EventArgs e)
        {
            flspcacilma.Visible = false;
            flsfare.Visible = false;
            flsklavye.Visible = true;
            flsnedenbilisim.Visible = false;
            grbdonanim.Visible = false;
            grbyardim.Visible = false;
            if (!animator.isActive)
            {
                animator.activeRipple((Button)sender, Color.Goldenrod);
            }
            MessageBox.Show("Klavye Kullanımı Aşamasına Geçtiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            flsklavye.Movie = Application.StartupPath + "\\klavye.swf";
            flsklavye.Loop = false;
            flsklavye.Play();
            timer.Start();
        }
        private void frmkurultay_Load(object sender, EventArgs e)
        {
            timer1.Start();
            flsintro.Location = new Point(0,0);
            flsintro.Width = 1071;
            flsintro.Height = 875;
            flsintro.Movie = Application.StartupPath + "\\intro.swf";
            flsintro.Loop = false;
            flsintro.Play();
            btnpcacma.Enabled = true;
            btnfare.Enabled = false;
            btnklavye.Enabled = false;
            btnbilisim.Enabled = false;
            btndonanim.Enabled = false;
            flspcacilma.Visible = false;
            flsfare.Visible = false;
            flsklavye.Visible = false;
            flsnedenbilisim.Visible = false;
            grbdonanim.Visible = false;
            grbyardim.Visible = false;
        }
        private void btnbilisim_Click(object sender, EventArgs e)
        {
            flspcacilma.Visible = false;
            flsfare.Visible = false;
            flsklavye.Visible = false;
            flsnedenbilisim.Visible = true;
            grbdonanim.Visible = false;
            grbyardim.Visible = false;
            if (!animator.isActive)
            {
                animator.activeRipple((Button)sender, Color.Goldenrod);
            }
            MessageBox.Show("Bu Aşamada Bilişime Neden İhtiyacımız Var, Nedir Bunun Olayı Bunları Anlamaya Çalışacağız.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            flsnedenbilisim.Movie = Application.StartupPath + "\\NedenBilisim.swf";
            flsnedenbilisim.Loop = false;
            flsnedenbilisim.Play();
            timer.Start();
        }
        private void btndonanim_Click(object sender, EventArgs e)
        {
            flspcacilma.Visible = false;
            flsfare.Visible = false;
            flsklavye.Visible = false;
            flsnedenbilisim.Visible = false;
            grbdonanim.Visible = true;
            grbyardim.Visible = false;
            if (!animator.isActive)
            {
                animator.activeRipple((Button)sender, Color.Goldenrod);
            }
            MessageBox.Show("Uygulamamız geliştirilmeye devam etmektedir, gelecek yeni güncellemeler ile bu butonumuzda da yeni şeyler öğrenmeye devam edeceğiz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            timer.Start();
        }
        private void btnyardim_Click(object sender, EventArgs e)
        {
            if (!animator.isActive)
            {
                animator.activeRipple((Button)sender, Color.Red);
            }
        }
        private void btnyardim_Click_1(object sender, EventArgs e)
        {
            //215;159       187; 87             855; 610
            flspcacilma.Visible = false;
            flsfare.Visible = false;
            flsklavye.Visible = false;
            flsnedenbilisim.Visible = false;
            grbdonanim.Visible = false;
            grbyardim.Visible = true;
            if (!animator.isActive)
            {
                animator.activeRipple((Button)sender, Color.Goldenrod);
            }
        }
        private void btncikis_Click_1(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Programı Kapatmak İstediğinizden emin misiniz?", "Kapat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac==55)
            {
                BTnoGrEnDiM.Visible = true;
                timer.Stop();
                sayac++;
            }
            else if (sayac==160)
            {
                BTnoGrEnDiM.Visible = true;
                timer.Stop();
                sayac++;
            }
            else if (sayac==241)
            {
                BTnoGrEnDiM.Visible = true;
                timer.Stop();
                sayac++;
            }
            else if (sayac==330)
            {
                BTnoGrEnDiM.Visible = true;
                timer.Stop();
                sayac++;
            }
        }
        private void btnrpcacilisi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tebrikler. Bu rozet artık senin! ");
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac1++;
            if (sayac1==5)
            {
                btngec.Visible = true;
            }
            if (sayac1==77)
            {
                btngec.Visible = false;
            }
            if (sayac1==77)
            {
                flsintro.Stop();
                flsintro.Visible = false;
                timer1.Stop();
            }
        }

        private void btngec_Click(object sender, EventArgs e)
        {
            flsintro.Stop();
            flsintro.Visible = false;
            btngec.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnfare.Visible = true;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!animator.isActive)
            {
                animator.activeRipple((Button)sender, Color.Goldenrod);
            }
            sayackonu++;
            if (sayackonu==1)
            {
                btnfare.Enabled = true;
                BTnoGrEnDiM.Visible = false;
                picpc.Visible = false;
            }
            if (sayackonu==2)
            {
                btnklavye.Enabled = true;
                BTnoGrEnDiM.Visible = false;
                picfare.Visible = false;
            }
            if (sayackonu==3)
            {
                btnbilisim.Enabled = true;
                BTnoGrEnDiM.Visible = false;
                picklavye.Visible = false;
            }
            if (sayackonu==4)
            {
                btndonanim.Enabled = true;
                BTnoGrEnDiM.Visible = false;
                picbilisim.Visible = false;
            }
        }
    }
}
