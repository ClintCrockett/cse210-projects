//Contains the reference to the scripture and makes it look nice
//Jacob Strong Austin Reeves
public class Reference{
    string js_book = "";
    int js_chapter = 0;
    int js_singleVerse = 0;
    string js_verses = "";
    string js_reference = "";

    public void js_inputRef(string input){
    //gets the reference for the desired scripture and puts it into useable variables
        int space = input.IndexOf(" ");
        int colon = input.IndexOf(":");
        int dash = input.IndexOf("-");
        int count = 0;

        while(count < space){
            js_book = js_book + input[count];
        }
        js_reference = js_reference + js_book;

        count = space+1;
        string chapterString = "";
        while (count < colon){
            chapterString = chapterString + input[count];
        }
        js_chapter = int.Parse(chapterString);
        js_reference = js_reference + js_chapter;

        count = colon+1;
        if(dash != -1){
            while (count < input.Length){
                js_verses = js_verses + input[count];
            }
            js_reference = js_reference + js_verses;
        }
        else{
            while (count < input.Length){
                js_verses = js_verses + input[count];
            }
            js_singleVerse = int.Parse(js_verses);
            js_reference = js_reference + js_singleVerse;
        }
    }

    public string getBook(){
    //returns the book name
        return js_book;
    }

    public int getChapter(){
    //returns the chapter number
        return js_chapter;
    }

    public int getSingleVerse(){
    //returns verse if its a single verse
        return js_singleVerse;
    }

    public string getVerses(){
    //returns verses if its multiple verses
        return js_verses;
    }

    public string getReference(){
    //returns the whole reference
        return js_reference;
    }
}