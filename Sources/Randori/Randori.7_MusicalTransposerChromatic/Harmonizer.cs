using System.Collections.Generic;
using System.Linq;
using System;

namespace Randori._7_MusicalTransposerChromatic
{
    public static class Harmonizer
    {
        private static List<string> _possibleNotes = new List<string>
        {
            "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B"
        };

        //public static string Transpose3(string noteName, int transposition)
        //{
        //    if (noteName == "B" && transposition == 1)
        //    {
        //        return "C";
        //    }
        //    var index = _possibleNotes.FindIndex(a => a.Contains(noteName));
        //    if (transposition < 0)
        //    {
        //        var newTransposition = transposition * (-1);
        //        for (int i = 0; i <= newTransposition; i++)
        //        {
        //            index++;
        //        }
        //        var resultNew = _possibleNotes.ElementAt(index);
        //        return resultNew;
        //    }
        //    else
        //    {
        //        for (int i = 0; i <= transposition; i++)
        //        {
        //            index++;
        //        }

        //        var result = _possibleNotes.ElementAt(index);

        //        return result;
        //    }
        //}


        public static string Transpose(string noteName, int transposition)
        {
            Console.WriteLine($"{noteName}{transposition}");
            var count = _possibleNotes.Count;
            var index = _possibleNotes.FindIndex(x => x == noteName);
            var d = new List<string>();
            if (transposition > 0)
            {
                for (var i = index; i < count; i++)
                {
                    d.Add(_possibleNotes[i]);
                }

                for (var i = 0; i <= index; i++)
                {
                    d.Add(_possibleNotes[i]);
                }
            }
            else
            {
                for (var i = index; i >= 0; i--)
                {
                    d.Add(_possibleNotes[i]);
                }

                for (var i = count - 1; i > index; i--)
                {
                    d.Add(_possibleNotes[i]);
                }

                transposition = transposition * -1;
            }

            if (transposition == 12)
            {
                transposition = 0;
            }

            return d.Take(transposition + 1).Last();
            //return new[]{"C","C#","D","D#","E","F","F#","G","G#","A","A#","B"}[(12+t+Array.IndexOf(new[]{"C","C#","D","D#","E","F","F#","G","G#","A","A#","B"},n))%12];
        }

        ////    "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B"
        //public static string Transpose(string noteName, int transposition)
        //{
        //    var index = _possibleNotes.IndexOf(noteName) + 1;

        //    if (transposition > 0)
        //    {
        //        return _possibleNotes[Math.Abs(index + transposition - 11) - 1];
        //    }

        //    if (transposition < 0)
        //    {
        //        _possibleNotes = _possibleNotes.ToArray().Reverse().ToList();
        //        return _possibleNotes[Math.Abs(_possibleNotes.IndexOf(noteName) + 1 + 12 - 10 - 1) + 1];
        //    }

        //    return _possibleNotes[index - 1];
        //}
    }
}