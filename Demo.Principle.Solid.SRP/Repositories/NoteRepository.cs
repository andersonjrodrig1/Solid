using Demo.Principle.Solid.SRP.DALL;
using Demo.Principle.Solid.SRP.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Demo.Principle.Solid.SRP.Repositories
{
    public class NoteRepository
    {
        private readonly NoteDao _noteDao;

        public NoteRepository()
        {
            _noteDao = new NoteDao();
        }

        public void AddNote(Note note) => _noteDao.notes.Add(note);

        public IList<Note> GetNotesByStudent(int studentId)
        {
            var notes = _noteDao.notes.Where(n => n.StudentId == studentId).ToList();

            return notes;
        }
    }
}
