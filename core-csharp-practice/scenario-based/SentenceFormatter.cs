using System;
class Sentence{
    //method building for formattting the sentence 
    static string Format(string str)
    {
        char[] arr =  new char[str.Length*2]; //arr to store the stirng 
        int index = 0;                         //index for the result

        bool capital = true; //flag for capital kletters 
        bool space = false;  //flag for allowed spaces 
        
        for(int i=0;i<str.Length;i++)//loop for traverse the string 
        {
            char ch = str[i];        //string into single char 
            switch (ch)
            {
                case ' ':           //handle the spacse 
                if (space)
                    {
                        arr[index++]=' ';
                        space=false;
                    }
                     break;

                case '.':               //handle the punctuations  marks 
                case '?':
                case '!':
                arr[index++]=ch;
                arr[index++]=' ';
                capital=true;
                space=false;
                break;
  

                default:                  //handle the characters 
                    if (capital && ch >= 'a' &&  ch <=  'z')
                    {
                        ch=(char)(ch-32);  //convert to uppercase 
                        capital = false;
                    }
                    else if(capital)
                    {
                        capital = false;
                    }
                    arr[index++] = ch;
                    space = true;
                    break;
            }
        }
            int len  =    index;//remove trailing spaces
            if(len>0 && arr[len-1]==' ')
            {
                len--;
            }
            char[] finalarr  = new char[len];//copy the excat size of thr arrar
            for(int i = 0; i < len; i++)
            {
                finalarr[i]=arr[i];
            }
        
        return new string(finalarr);
    }
    static void Main()
    {
        Console.WriteLine("Enter the sentence  ");
        string str=Console.ReadLine();//take input of string from user 

        string output=Format(str);//call the method
        Console.WriteLine(output);//display the reuslt

    }
}