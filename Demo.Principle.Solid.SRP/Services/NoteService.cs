using Demo.Principle.Solid.SRP.Entities;
using Demo.Principle.Solid.SRP.Repositories;
using System.Collections.Generic;
using System.Linq;

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

        public bool VerifyIfNotesRegister(int studentId)
        {
            var notes = _noteRepository.GetNotesByStudent(studentId);

            return notes.Any();
        }

        public IList<Note> GetNoteByStudent(int studentId) => _noteRepository.GetNotesByStudent(studentId);
    }
}
