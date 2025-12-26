public class Phrase
{
    public string Text { get; private set; }

    public Phrase(string text)
    {
        string textToAdd = text.Trim();
        if (textToAdd == "")
        {
            throw new NullTextException();
        }
        if (textToAdd.Length > 500)
        {
            throw new TextLongException();
        }
        Text = textToAdd;
    }

}