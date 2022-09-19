namespace Assignment2;
public delegate void StringChanger(string s);
public class DelegatesAndAnonymousMethods{

    //Line reverse part    
    string theLine = ""; 
    public void WriteLineReverse (string s){
        StringChanger reverser = new StringChanger(reverse);
        reverser(s);
        Console.WriteLine(theLine);
    }

    public void reverse (string s){
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        string reversed = new String(charArray);
        theLine = reversed;
    }
    

    // return product part
    static double Sum(double a, double b){
        return a*b;
    }
    Func<double, double, double> product = Sum;

    public double GetProduct (double a, double b){
        return product(a, b);
    }

    // Check equality part
    static bool checkEqual(string a, int b){
        int stringInInt = int.Parse(a);
        if(stringInInt == b){
            return true;
        }
        return false;
    }
    Func<string, int, bool> equal = checkEqual;

    public bool isItEqual (string a, int b){
        return equal(a, b);
    }
}
