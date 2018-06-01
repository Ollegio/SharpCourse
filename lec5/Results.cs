using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lec5
{
    public partial class Results : Form
    {
        public Results()
        {
            InitializeComponent();
        }

        private void Results_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_lec5_GameModelDataSet.GameEntities". При необходимости она может быть перемещена или удалена.
            this.gameEntitiesTableAdapter.Fill(this._lec5_GameModelDataSet.GameEntities);

        }
    }
}
