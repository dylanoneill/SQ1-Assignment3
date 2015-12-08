using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriangleForm{

    public partial class TriangleForm : Form{

        Triangle t;
        double sideA;
        double sideB;
        double sideC;

        double angleA;
        double angleB;
        double angleC;

        double area;

        public TriangleForm()  {

            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e) {
            sideA = double.Parse(SideATextbox.Text);
            sideB = double.Parse(SideBTextbox.Text);
            angleC = double.Parse(AngleCTextbox.Text);
            if (sideA > 0 && sideB > 0 && angleC == 90) {
                t = new Triangle();
                HypotenuseTextbox.Text = Convert.ToString((int)t.CalculateHypotenuse(sideA, sideB));
            }
        }

        private void ThirdAngleButton_Click(object sender, EventArgs e){
            angleA = double.Parse(AngleATextbox.Text);
            angleB = double.Parse(AngleBTextbox.Text);
            angleC = double.Parse(AngleCTextbox.Text);

            t = new Triangle();
            if (angleA == 0) {
                ThirdAngleTextbox.Text = Convert.ToString((int)t.CalculateThirdAngle(angleB, angleC));
            } else if (angleB == 0) {
                ThirdAngleTextbox.Text = Convert.ToString((int)t.CalculateThirdAngle(angleA, angleC));
            } else if (angleC == 0) {
                ThirdAngleTextbox.Text = Convert.ToString((int)t.CalculateThirdAngle(angleA, angleB));
            }
        }

        private void AreaButton_Click(object sender, EventArgs e) {
            sideA = double.Parse(SideATextbox.Text);
            sideB = double.Parse(SideBTextbox.Text);

            if (sideA > 0 && sideB > 0){
                t = new Triangle();
                AreaTextbox.Text = Convert.ToString((int)t.CalculateArea(sideA, sideB));
            }
        }
    }
}
