using Demo.Principle.Solid.SRP.Entities;
using System.Collections.Generic;

namespace Demo.Principle.Solid.SRP.DALL
{
    public class NoteDao : BaseDao<Note>
    {
        public IList<Note> notes = new List<Note>();
    }
}
