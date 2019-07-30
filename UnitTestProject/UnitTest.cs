using ExercicesBase.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void CreateEleveWithoutError()
        {
            Eleve eleve = new Eleve("Harksa", 18, 0);
            eleve = new Eleve("Harksa", 26, 0);
            eleve = new Eleve("Harksa", 18, 20);
            eleve = new Eleve("Harksa", 26, 20);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidAgeException))]
        public void CreateEleveAgeError() {
            Eleve eleve = new Eleve("Harksa", 99, 18);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidNoteException))]
        public void CreateEleveMoyenneError() {
            Eleve eleve = new Eleve("Harksa", 20, 21);
        }
    }
}
