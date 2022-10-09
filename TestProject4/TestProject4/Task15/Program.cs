// სავარჯიშო 15
//დაწერეთ პროგრამა რომელიც იპოვნის ტექსტი შეიცავს თუ არა
//substring-ს (მაგ: some text    შეიცავს ext-ს ? შეიცავს!)

string st = "some text";
string st1 = "ext";

bool result = st.Contains(st1);
Console.WriteLine(result);

string st2 = st.Substring(2);
Console.WriteLine(st2);