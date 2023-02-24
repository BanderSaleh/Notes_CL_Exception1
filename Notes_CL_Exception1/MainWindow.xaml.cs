using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MyLibrary;

namespace Notes_CL_Exception1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //This Chapter Covering:
            // Class Libraries
            // Exceptions
            // Deconstructors // every object automatically has a Destructor:
            /* 
            // Destructor called with the Tilde ~ key below. It can be added to a Page with a Constructor(maybe?)
            ~Team()
                {
                    // Missing code here...
                }
            */
            //If a Destructor is used, it will be the last thing the assigned object will do



            // Class Libraries gets called
            MessageBox.Show(MyLibrary.MyMath.Add(1, 2).ToString());


            // Exceptions
            try
            {
                "6".RollTheDie().ToString();
            }
            catch(EncoderFallbackException efe)
            {
                MessageBox.Show("You made an error");
            }
            catch(Exception ex)
            {
                MessageBox.Show("This was a regular exception " + ex.Message);
            }
        
        
        }
    }
}
