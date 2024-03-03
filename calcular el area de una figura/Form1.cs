namespace calcular_el_area_de_una_figura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void circle_Click(object sender, EventArgs e)
        {
            double radius = double.Parse(radiustxt.Text);

            Circle rad = new Circle(radius);

            double areaCircle = rad.area();

            // Mostrar el resultado
            MessageBox.Show($"the area for triangle is: {areaCircle}");
        }

        private void triangle_Click(object sender, EventArgs e)
        {
            double baseTriangulo = double.Parse(Basetxt.Text);
            double heightTriangulo = double.Parse(Heighttxt.Text);


            Triangle triangle = new Triangle(baseTriangulo, heightTriangulo);

            double areaTriangle = triangle.area();

            // Mostrar el resultado
            MessageBox.Show($"the area for triangle is: {areaTriangle}");
        }

        private void square_Click(object sender, EventArgs e)
        {
            double side_of_square = double.Parse(Sidetxt.Text);

            Square square = new Square(side_of_square); 

            double areaSquare = square.area();

            MessageBox.Show($"the area for square is: {areaSquare}");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void area_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
