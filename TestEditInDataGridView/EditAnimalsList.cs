using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestEditInDataGridView.Models;

namespace TestEditInDataGridView
{
    public partial class EditAnimalsList : Form
    {
        List<Animal> animalList = new List<Animal>();
        BindingSource animalListBinding = new BindingSource();
        public EditAnimalsList()
        {
            InitializeComponent();
        }

        private void EditAnimalsList_Load(object sender, EventArgs e)
        {
            animalList.Add(new Animal(1, "Dog", "4 Legs"));
            animalList.Add(new Animal(2, "Cat", "4 Legs"));
            animalList.Add(new Animal(3, "Spider", "6 Legs"));

            animalListBinding.DataSource = animalList;
            animalListDataGridView.DataSource = animalListBinding;

        }
    }
}
