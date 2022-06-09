namespace CrudMvc.Models
{
    public class Curriculum
    {
        public int Id { get; set; }

        public string Title { get; set; }


        /*[DataType(DataType.Date)]

        public DateTime ReleaseDate { get; set; }*/

        public string Genre { get; set; }

        public decimal Price { get; set; }

        public string Edad { get; set; }
    }
}

