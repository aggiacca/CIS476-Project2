using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COR2
{
    public partial class Form1 : Form
    {
        protected ConvertHandler mileHandler, yardHandler, footHandler;
        public Form1()
        {
            InitializeComponent();

            mileHandler = new MILE_Handler("Mile");
            yardHandler = mileHandler.SetNext(new YARD_Handler("Yard"));
            footHandler = yardHandler.SetNext(new FOOT_Handler("Foot"));
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String target = this.TargetUnitBox.Text;
            int inputNum = Int32.Parse(this.InputUnit.Text);

            Value output = mileHandler.Handle(target, inputNum);
            BaseValue baseVal = new BaseValue(output);

            RoundDecorator rounded = new RoundDecorator(baseVal);
            ExpDecorator expVal = new ExpDecorator(rounded);

            String value = expVal.getValue();

            this.OutputBox.Text = value;

        }
    }
}
