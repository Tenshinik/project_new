string ? term_new = Console.ReadLine();
int start = -1;
int end = -1;
Console.Write("[");
bool found = false;
for(int i = 0; i < term_new.Count(); i++)
{
    if(term_new[i] == '"')
    {
        if(start == -1)
        {
            start = i;
        }
        else
        {
            end = i;
            string term_1 = term_new.Substring(start + 1, end - start - 1);
            start = -1;
            end = -1;
           /* Console.Write(term_1);
            Console.Write(term_1.Length);*/
        if(term_1.Length <= 3)
        {
            if(found)
            {
                Console.Write(",");
            }
            Console.Write('"');
            Console.Write(term_1);
            Console.Write('"');
            found = true;
        }   

        }  
    }
}
    Console.Write("]");
