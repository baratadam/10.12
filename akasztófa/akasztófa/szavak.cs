using System.Security.Cryptography.X509Certificates;

namespace akasztófa;

public class Target
{
    public string Word;
    private string HashedWord; //*******

    public void SetWord(string word)
    {
        Word = word;
        for (int i = 0; i < word.Length; i++) ;
        {
            HashedWord = HashedWord + "*";
        }
    }
    public void CheckCharacter(char character)
        {
            for (int i = 0;i < Word.Length;i++) 
        {
            if (Word[i] == character);
        }
        }
    }
