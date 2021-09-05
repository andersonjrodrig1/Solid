using Demo.Principle.Solid.SRP.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Demo.Principle.Solid.SRP.DALL
{
    public class NoteDao : BaseDao<Note>
    {
        public IList<Note> notes = new List<Note>();

        public override void Add(Note note) => notes.Add(note);
        public override void Remove(Note note) => notes.Remove(note);
    }
}
