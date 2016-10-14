using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetNote.Models
{
    public class Data
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
    }

    public class DataService
    {
        private readonly List<Data> _data = new List<Data>()
        {
            new Data { Id = 1, Name = "김태영", Title = "안녕하세요." },
            new Data { Id = 2, Name = "박용준", Title = "반갑습니다." },
            new Data { Id = 3, Name = "한상훈", Title = "또 만나요." },
        };

        public List<Data> GetAll()
        {
            return _data;
        }

        public Data GetDataById(int id)
        {
            return _data.Where(n => n.Id == id).SingleOrDefault();
        }

        public List<Data> GetDataByName(string name)
        {
            return _data.Where(
                n => n.Name.ToLower().Equals(name.ToLower())).ToList();
        }
    }

    public class DataFinder
    {
        private DataService _service = new DataService();

        public async Task<Data> GetDataById(int id)
        {
            return await Task.FromResult(_service.GetDataById(id));
        }
    }
}
