using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BugTrackerMVCApp.Models;

namespace BugTrackerMVCApp.Controllers
{
    public class BugsDataController : ApiController
    {
        public static IList<Bug> BugRepository = new List<Bug>
        {
            new Bug(){id = 1, title = "asjflasj lfjadsljfsda", isClosed = false, createdAt = new DateTime(2015,04,18,9,0,0)},
            new Bug(){id = 2, title = "jdslfgkjdsfgs", isClosed = true, createdAt = new DateTime(2015,04,18,11,0,0)},
            new Bug(){id = 3, title = "ewuiotueowt", isClosed = false, createdAt = new DateTime(2015,04,18,10,0,0)},
        };
        // GET api/bugsdata
        public IEnumerable<Bug> Get()
        {
            return BugRepository;
        }

        // GET api/bugsdata/5
        public Bug Get(int id)
        {
            return BugRepository.FirstOrDefault(b => b.id == id);
        }

        // POST api/bugsdata
        public Bug Post(Bug bug)
        {
            var newId = BugRepository.Max(b => b.id) + 1;
            bug.id = newId;
            bug.createdAt = new DateTime();
            BugRepository.Add(bug);
            return bug;
        }

        // PUT api/bugsdata/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/bugsdata/5
        public void Delete(int id)
        {
        }
    }
}
