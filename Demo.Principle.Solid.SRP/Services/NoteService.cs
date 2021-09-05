using Demo.Principle.Solid.SRP.Entities;
using Demo.Principle.Solid.SRP.Repositories;
using System.Collections.Generic;

namespace Demo.Principle.Solid.SRP.Services
{
    public class NoteService
    {
        private readonly NoteRepository _noteRepository;

        public NoteService()
        {
            _noteRepository = new NoteRepository();
        }

        public void AddNote(int studentId, decimal value)
        {
            var note = new Note
            {
                StudentId = studentId,
                Value = value
            };

            _noteRepository.AddNote(note);
        }

        public IList<Note> GetNoteByStudent(int studentId) => _noteRepository.GetNotesByStudent(studentId);
    }
}
