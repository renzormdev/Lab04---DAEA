using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media.Media3D;

namespace Eva01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string cadena = "Server=LAB1507-13\\SQLEXPRESS03; Database=NeptunoB; Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("USP_ListarProveedores", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                List<Proveedor> listaProveedores = new List<Proveedor>();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Proveedor proveedor = new Proveedor
                        {
                            idProveedor = reader["idproveedor"].ToString(),
                            nombreCompañia = reader["nombrecompañia"].ToString(),
                            nombrecontacto = reader["nombrecontacto"].ToString(),
                            cargocontacto = reader["cargocontacto"].ToString(),
                            direccion = reader["direccion"].ToString()
                        };
                        listaProveedores.Add(proveedor);
                    }
                }

                datagrid.ItemsSource = listaProveedores;
            }
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string cadena = "Server=LAB1507-13\\SQLEXPRESS03; Database=NeptunoB; Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("USP_ListarCategorias", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                List<Categoria> listaCategorias = new List<Categoria>();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Categoria proveedor = new Categoria
                        {
                            idcategoria = reader["idcategoria"].ToString(),
                            nombrecategoria = reader["nombrecategoria"].ToString(),
                            descripcion = reader["descripcion"].ToString(),
                            Activo = reader["Activo"].ToString(),
                            CodCategoria = reader["CodCategoria"].ToString()
                        };
                        listaCategorias.Add(proveedor);
                    }
                }

                datagrid2.ItemsSource = listaCategorias;
            }
        }
    }
    }
}