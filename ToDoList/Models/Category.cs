using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Category
    {
        public Category()
        {
            this.Items = new HashSet<CategoryItem>();
        }

        public int CategoryId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<CategoryItem> Items { get; set; }
    }
}




public ActionResult Index()
{
    return View(_db.Items.ToList());
}



/*public ActionResult Details(int id)
{
    var thisItem = _db.Items go into the items table
        .Include(item => item.Categories) find all CategoryItem objects associated with the item
        .ThenInclude(join => join.Category) find the Category object that belongs to each CategoryItem
        .FirstOrDefault(item => item.ItemId == id); for the item that matches the id passed into this route
    return View(thisItem);
}*/
