using BeautySaloonForStudents.ModelEF;

namespace BeautySaloonForStudents
{
    public delegate void UpdateProducts();
    public delegate void UpdateCostProducts(Product product);
    public static class Getter
    {
        public static Model1 db = new Model1();
        public static UpdateProducts updateProducts = Program.mainForm.PrepareData;
        public static UpdateCostProducts updateCostProducts = Program.mainForm.UpdateProductCostList;
    }
}
