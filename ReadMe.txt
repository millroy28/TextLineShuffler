This is a quick and dirty randomizer I built to help me shuffle spotify playlists.
My use will be:
1	copy all from a spotify playlist
2	paste into new text file
3	save text file to directory of TextLineShuffler.exe
4	execute shuffler
5	open newly shuffled file
6	copy
7	paste into new spotify playlist


Is this stupid? Yes. Should I just be able to hit shuffle on my spotify playlist and enjoy some percieved true randomness? Yes. Do I hit shuffle now and hear the same 20 songs out of a 500 song playlist every dang time. Yes. Am I angry? Yes. Why do I keep spotify? I don't know.


What TextLineShuffler.exe does:
Prompts for a file name to shuffle 
Looks for that file in its own directory
Copies each row into a list of string
Shuffles that list
Writes that list to a new file
Prompts for another

This is all very crude and just a personal utility. Randomizer uses Random and Linq and performs the shuffle a total of 7 times because I liked the number and I thought of it as a deck of cards maybe.
