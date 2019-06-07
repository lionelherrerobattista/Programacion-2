using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Entidades_Ejercicio_60;


namespace Ejercicio_60_Form
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      
    }

    private void btnInsert_Click(object sender, EventArgs e)
    {

      string consulta;      
      
      consulta = String.Format("INSERT INTO Production.Product (Name, ProductNumber, SafetyStockLevel, ReorderPoint, StandardCost, ListPrice, DaysToManufacture, SellStartDate)  VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')",
        txtName.Text, txtProductNumber.Text, txtSafetyStockLevel.Text, txtReorderPoint.Text, txtStandardCost.Text, txtListPrice.Text, txtDaysToManufacture.Text, DateTime.Today);

      Consulta.Insert(consulta);
      

    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
      string consulta;

      consulta = String.Format("UPDATE Production.Product SET Name = '{0}' WHERE ProductID = {1}", txtName.Text, txtProductID.Text);

      Consulta.Update(consulta);

    }
  }
}
