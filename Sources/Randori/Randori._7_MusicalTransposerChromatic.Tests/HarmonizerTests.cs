using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Randori._7_MusicalTransposerChromatic.Tests
{
    [TestClass]
    public class HarmonizerTests
    {
        //"C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B"
        [TestMethod]
        public void Harmonizer_Transpose_Asharp_12_Csharp()
        {
            //arrange
            const string note = "A#";
            const int transposition = -12;

            //action
            var result = Harmonizer.Transpose(note, transposition);

            //assert
            Assert.AreEqual("A#", result);
        }

        [TestMethod]
        public void Harmonizer_Transpose_B_C()
        {
            //arrange
            const string note = "B";
            const int transposition = 1;

            //action
            var result = Harmonizer.Transpose(note, transposition);

            //assert
            Assert.AreEqual("C", result);
        }
    }
}
