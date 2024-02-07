namespace PokéRepo.Models
{
    public class Root
    {
        public int Id { get; set; }
        public int Height { get; set; }
        public int Base_experience { get; set; }
        public string Name { get; set; }
        public List<Ability> Abilities { get; set; }
        public List<Form> Forms { get; set; }

    }

    public class Ability
    {
        public Ability2 ability { get; set; }
        public bool is_hidden { get; set; }
        public int slot { get; set; }
    }

    public class Ability2
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Form
    {
        public string Name { get; set; }
        public string url { get; set; }
    }

}
