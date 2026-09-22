namespace TH_H60_A01.Models
{
    public class ProductCategoryDB
    {
        private readonly H60AssignmentDbThContext _context;

        public ProductCategoryDB(H60AssignmentDbThContext context)
        {
            _context = context;
        }

        public List<ProductCategory> GetAll()
        {
            return _context.ProductCategories.ToList();
        }

        public ProductCategory? GetById(int id)
        {
            return _context.ProductCategories.Find(id);
        }

        public void Add(ProductCategory category)
        {
            _context.ProductCategories.Add(category);
            _context.SaveChanges();
        }

        public void Update(ProductCategory category)
        {
            _context.ProductCategories.Add(category);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var category = _context.ProductCategories.Find(id);

            if (category != null)
            {
                _context.ProductCategories.Remove(category);
                _context.SaveChanges();
            }
        }
    }
}
