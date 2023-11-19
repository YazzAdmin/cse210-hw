
class Word {
    private string _word ;
    private Boolean _visibility;


    public Word (){ 

    }
    public Word (string word , Boolean visibility){ 
        _word = word ;  
        _visibility = visibility;
    }


    public void SetWord(string word ){
        _word = word;
    }
    public void SetVisibility(Boolean visibility){
        _visibility = visibility;
    }

    public string GetWord(){
        return _word;
    }
    public Boolean GetWordVisibility(){
        return _visibility;
    }



    // methods

    // NOTemethod is needed to change the visibility.


}


