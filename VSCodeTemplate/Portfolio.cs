using System.Collections.Generic;

namespace VSCodeTemplate
{
    public class Portfolio
    {
        private IList<string> _projects = new List<string>();

        public string Id { get; set; }

        public string Description { get; set; }

        IEnumerable<string> Projects => _projects;

        public void AddProject(string name)
        {
            _projects.Add(name);
        }

    }
}