namespace Consonant;
public static class Method
{
    private static string[] wordList;

    private static string getWords(){
        System.Console.Write("Please, enter words with spaces between them (hello computer work) : ");
        return Console.ReadLine().Trim();
    }

    private static bool spaceControl(string words){
        if(words == ""){
                System.Console.WriteLine("No words were entered. Please enter one or more words with a space between them.");
                return false;
            }

        for (int i = 0; i < words.Length; i++)
        {
            if(words[i] == ' ' && words[i+1] == ' '){
                System.Console.WriteLine("You have entered incorrectly. Please, enter with a space between the two words...");
                return false;
            }
        }
        wordList = words.Split(' ');
        return true;
    }

    public static void mainMethod()
    {
        Back:
        string words = getWords();
        if (spaceControl(words))
        {
            AlgoritmaMethod();
        }else{
            goto Back;
        }
    }

    private static void AlgoritmaMethod()
    {
        bool consonant = false;
        bool result = false;
        foreach (var item in wordList)
        {
            foreach (var ch in item)
            {
                if ( consonant && consonantMethod(ch))
                {
                    result = true;
                    break;
                }
                consonant = consonantMethod(ch);
            }
            if(result){
                System.Console.Write("True ");
            }else{
                System.Console.Write("False ");
            }
            result=false;
            consonant = false;
        }
    }

    private static bool consonantMethod(char ch)
    {
        string consonant = "zyvtşsrpnrmlkhjğgdçcb";
        foreach (var item in consonant)
        {
            if (ch == item)
            {
                return true;
            }
        }
        return false;
    }
}
