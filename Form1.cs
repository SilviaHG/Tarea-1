using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea1
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

        private void button1_Click(object sender, EventArgs e)
        {
            /*
             * 1.	Declara e inicializa un array de enteros 
             *      llamado numeros con los valores {10, 20, 30, 40, 50}. Luego,
             *       imprime su longitud.
             * */
            int[] numeros = { 10, 20, 30, 40, 50 };
            MessageBox.Show($"La Longitud es de: {numeros.Length} ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
             * 2.	Dado el array numeros = {5, 10, 15, 20, 25}, 
             *      escribe un código que establezca el valor del tercer elemento (índice 2) a 100.
             *      Luego, imprime el array completo.
             * */
            int[] numeros = { 5, 10, 15, 20, 25 };

            

            DialogResult optUser = MessageBox.Show($"Desea modificar el indice 2 '{numeros[2]}' por un 100?",
            "Advertencia", MessageBoxButtons.YesNo);

            switch (optUser)
            {
                case DialogResult.Yes:
                    numeros[2] = 100;

                    string msg = string.Join(Environment.NewLine, numeros);
                    MessageBox.Show($"{msg}");

                break;

                case DialogResult.No:

                    string ms = string.Join(Environment.NewLine, numeros);
                    MessageBox.Show($"{ms}");
                    
                break;
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*
             * 3.	Crea un array de strings llamado nombres con los valores
             * {"Ana", "Luis", "Pedro", "Marta"}.
             * Busca el índice del nombre "Pedro" e imprímelo.
             * */

            string[] nombres = { "Ana", "Luis", "Pedro", "Marta" };

            foreach (string buscar in nombres)
            {
                if (buscar == "Pedro")
                {
                    MessageBox.Show($"Encontramos el nombre: {buscar}");
                    
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*
             * 4.	Dado el array numeros = {50, 40, 30, 20, 10}, 
             * escribe un código que ordene el array en orden ascendente y luego lo imprima.
             * */

            int[] numeros = { 50, 40, 30, 20, 10 };
            Array.Sort(numeros); // ordeno de manera ascendente
            string msg = string.Join(Environment.NewLine, numeros); // para convertirlos en una sola cadena
            MessageBox.Show($"{msg}");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            /*
             * 5.	Escribe un código que invierta el array 
             * numeros = {1, 2, 3, 4, 5} y luego imprima los elementos en el nuevo orden.
             * */
            int[] numeros = { 1, 2, 3, 4, 5 };
            Array.Reverse(numeros); // invierto el array
            string msg = string.Join(Environment.NewLine, numeros); // para convertirlos en una sola cadena
            MessageBox.Show($"{msg}");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            /*
             * 6.	Dado el array numeros = {10, 20, 30, 40, 50}, 
             * usa el método Array.Clear para establecer a cero los elementos 
             * desde el índice 1 hasta el índice 3. Luego, imprime el array.
             * */

            int[] numeros = { 10, 20, 30, 40, 50 };
            
            for (int i = 1; i < numeros[3]; i++)
            {
                
                Array.Clear(numeros, 1, 3);
            }

            string msg = string.Join(Environment.NewLine, numeros); // para convertirlos en una sola cadena
            MessageBox.Show($"{msg}");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            /*
             * 7.	Crea dos arrays de enteros origen y destino.
             * Copia todos los elementos de origen = {1, 2, 3, 4, 5} a destino y 
             * luego imprime destino.
             * */

            int [] origen = { 1,2, 3, 4,5 }; // creamos el array lleno
            int[] destino = new int[origen.Length]; // creamos un array con el mismo tamaño del origen

            Array.Copy(origen, destino, origen.Length); // copeamos el array de origen a destino


            string msg = string.Join(Environment.NewLine, destino); // para convertirlos en una sola cadena
            MessageBox.Show($"{msg}");

        }

        private void button8_Click(object sender, EventArgs e)
        {
            /*
             * 8.	Escribe un código que encuentre el primer número mayor 
             * que 20 en el array numeros = {10, 20, 30, 40, 50} utilizando el método
             * Array.Find. Imprime el número encontrado.
             * */

            int [] numeros = {10,20, 30, 40,50};

            int mayor20 = Array.Find(numeros, x => x > 20);

            MessageBox.Show($"{mayor20}");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            /*
             * 9.	Crea un array de enteros llamado valores con los valores 
             *      {1, 3, 5, 7, 9}. Escribe un código que verifique si existe un número
             *       mayor que 6 en el array utilizando Array.Exists e imprime el resultado
             *      (true/false).
             * */

            int[] valores = { 1, 3, 5, 7, 9 };

            bool existe = Array.Exists(valores, x => x > 6);

            if ( existe )  {
                MessageBox.Show($"{existe}");
            }
            else
            {
                MessageBox.Show($"{existe}");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            /*
             * 10.	Dado el array numeros = {2, 4, 6, 8, 10}, usa el método
             * Array.Find para buscar el primer número par en el array.
             * Imprime el número encontrado.
             * */

            int[] numeros = { 1, 3, 7, 8, 10 };

            int find = Array.Find(numeros, s => s %2 == 0);

            MessageBox.Show($"{find}");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            /*
             * 11.	Crea un array de strings llamado frutas con los valores 
             * {"manzana", "banana", "naranja", "kiwi"}. Usa el método Array.IndexOf 
             * para encontrar el índice de "kiwi" e imprímelo.
             * */

            string[] valores = { "manzana", "banana", "naranja", "kiwi" };

            int find = Array.IndexOf(valores, "kiwi");

            MessageBox.Show($"{find}");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            /*
             * 12.	Dado el array numeros = {15, 25, 35, 45, 55}, usa el método
             * Array.Clear para establecer a cero los elementos desde el índice 
             * 2 hasta el índice 4. Luego, imprime el array completo.
             * */


            int[] numeros = { 15, 25, 35, 45, 55 };

            for (int i = 0; i < numeros.Length; i++)
            {

                Array.Clear(numeros, 2, 4-1);
            }

            string msg = string.Join(Environment.NewLine, numeros); // para convertirlos en una sola cadena
            MessageBox.Show($"{msg}");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            /*
             * 13.	Crea un array de enteros llamado datos con los valores 
             * {5, 10, 15, 20, 25}. Copia los primeros 3 elementos de datos a 
             * un nuevo array llamado subDatos y luego imprime subDatos.
             * */

            int[] datos = { 5, 10, 15, 20, 25 };
            int[] subDatos = new int[3];

            Array.Copy(datos, subDatos, 3);

            string msg = string.Join(Environment.NewLine, subDatos); // para convertirlos en una sola cadena
            MessageBox.Show($"{msg}");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            /*
             * 14.	Utiliza el método Array.Reverse para invertir 
             * el orden de los elementos en el array valores = {3, 6, 9, 12, 15} 
             * y luego imprime el resultado.
             * */

            int[] datos = { 3, 6, 9, 12, 15 };

            Array.Reverse(datos);

            string msg = string.Join(Environment.NewLine, datos); // para convertirlos en una sola cadena
            MessageBox.Show($"{msg}");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            /*
             * 15.	Escribe un código que verifique si el número 10 está presente 
             * en el array numeros = {5, 10, 15, 20, 25} usando el método Array.Exists.
             * Imprime el resultado (true/false).
             * */

            int[] datos = { 5, 10, 15, 20, 25 };

            bool existeTEN = Array.Exists(datos, s => s == 10);
            if (existeTEN)
            {
                MessageBox.Show($"{existeTEN}");
            }
            else
            {
                MessageBox.Show($"{existeTEN}");
            }

            // Obtener el valor mínimo 
            int mini = datos.Min();
            MessageBox.Show($"Valor mínimo: {mini}");

            // Obtener el valor máximo 
            int maximo = datos.Max(); 
            MessageBox.Show($"Valor máximo: {maximo}");

            // Obtener la suma 
            int sumaTotal = datos.Sum();
            MessageBox.Show($"La suma total es: {sumaTotal}");
        }
    }
}
