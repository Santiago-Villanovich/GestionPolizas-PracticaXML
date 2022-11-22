using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BE;
using BLL;


namespace Modelo2doParcialXML
{
    public partial class FormInformes : Form
    {
        public FormInformes()
        {
            InitializeComponent();
            bllAuto = new BLLpAutomovil();
            bllMar = new BLLpMaritima();
            
        }
        BLLpAutomovil bllAuto;
        BLLpMaritima bllMar;
        public void ChartLoad()
        {
            if (radioButton1.Checked == true)
            {
                List<BEPautomovil> lista = bllAuto.Listar();

                Dictionary<int, double> dic = new Dictionary<int, double>();

                foreach (BEPautomovil item in lista)
                {
                    BEPautomovil auto = item;
                    dic.Add(auto.ID, auto.Tasa);
                }

                chart1.Titles.Clear();
                chart1.ChartAreas.Clear();
                chart1.Series.Clear();

                ChartArea area = new ChartArea();
                area.Area3DStyle.Enable3D = false;
                chart1.ChartAreas.Add(area);

                Series serie = new Series();
                serie.ChartType = SeriesChartType.Column;
                serie.Points.DataBindXY(dic.Keys,dic.Values);

                chart1.Series.Add(serie);

            }
            else if(radioButton2.Checked == true)
            {
                List<BEPmaritima> lista = bllMar.Listar();

                Dictionary<int, double> dic = new Dictionary<int, double>();
                foreach (BEPmaritima item in lista)
                {
                    BEPmaritima mar = item;
                    dic.Add(mar.ID, mar.Tasa);
                }

                chart1.Titles.Clear();
                chart1.ChartAreas.Clear();
                chart1.Series.Clear();

                ChartArea area = new ChartArea();
                area.Area3DStyle.Enable3D = true;
                chart1.ChartAreas.Add(area);

                Series serie = new Series();
                serie.ChartType = SeriesChartType.RangeBar;
                serie.Points.DataBindXY(dic.Keys,dic.Values);

                chart1.Series.Add(serie);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ChartLoad();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ChartLoad();
        }
    }
}
