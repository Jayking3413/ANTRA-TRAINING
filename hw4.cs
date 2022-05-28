
//1
//04 Generics
//Test your Knowledge
//1. Describe the problem generics address.
//allow us to design classes and methods but defer the specification or types until the class or method is declared and called

//2. How would you create a list of strings, using the generic List class?

//List < string > ls = new List<string>

//3.How many generic type parameters does the Dictionary class have?

//two.Key and value.

//4.True
//When a generic class has multiple type parameters, they must all match.

//5. What method is used to add items to a List object?

//list.Add()

//6. Name two methods that cause items to be removed from a List.

//list.Remove()
//list.RemoveAT()

//7. How do you indicate that a class has a generic type parameter?

//ClassName<T>

//8. True/False. Generic classes can only have one generic type parameter.

//False. (like dictionary)

//9. True
//Generic type constraints limit what can be used for the generic type.

//10. True
//Constraints let you use the methods of the thing you are constraining to.



//Practice working with Generics
//1. Create a custom Stack class MyStack<T> that can be used with any data type which has following methods
//1. int Count()
//2.T Pop()
//3.Void Push()

public class MyStack<T>
{
    public List<T> Stack { get; set; }
    public int cnt { get; set; }
    public MyStack()
    {
        Stack = new List<T>();
        cnt = 0;
    }
    public int Count()
    {
        return cnt;
    }
    public T Pop()
    {
        T temp = Stack[cnt];
        Stack.RemoveAt(cnt);
        cnt--;
        return temp;
    }
    public void push(T item)
    {
        Stack.Add(item);
        cnt++;
    }
}





//2.Create a Generic List data structure MyList<T> that can store any data type.
//Implement the following methods.
//1. void Add (T element)
//2. T Remove(int index)
//3. bool Contains(T element)
//4. void Clear()
//5. void InsertAt(T element, int index)
//6. void DeleteAt(int index)
//7. T Find(int index)

public class MyList<T>{

    public List<T> List { get; set; }
    public int cnt { get; set; }

    public MyList()
    {
        List = new List<T>();
        cnt=0;
    }
    public void Add(T e)
    {
        List.Add(e);
        cnt++;
    }
    public T Remove(int index)
    {
        T temp = List[index];
        List.RemoveAt(index);
        cnt--;
    }
    public bool Constains(T e)
    {
        foreach (T item in List)
        {
            if (item.Equals(e))
            {
                return true;
            }
        }
        return false;
    }
    public void Clear()
    {
        List.Clear();
        cnt = 0;
    }
    public void InserAt(T element, int index)
    {
        List<T> temp = new List<T>();
        int i = 0;
        bool flag = true;
        Cnt++;
        while (i < cnt)
        {
            if (i == index && flag)
            {
                temp.Add(element);
                flag = false;
                continue;
            }
            temp.Add(List[i]);
            i++;
        }
    }
    public void DeletAt(int index)
    {
        if (index < cnt)
        {
            List.RemoveAt(index);
            cnt--;
        }
        else
        {
            throw new IndexOutOfRangeException();
        }
    }
    public T Find(int index)
    {
        if (index < cnt)
        {
            return List[index];
        }
        else
        {
            throw new IndexOutOfRangeException();
        }
    }
}





//3.Implement a GenericRepository<T> class that implements IRepository<T> interface that will have common /CRUD/ operations so that it can work with any data source
//such as SQL Server, Oracle, In-Memory Data etc. Make sure you have a type constraint on T were it should be of reference type and can be of type Entity which has one
//property called Id. IRepository<T> should have following methods
//1. void Add(T item)
//2. void Remove(T item)
//3.Void Save()
//4.IEnumerable < T > GetAll()
//5.T GetById(int id)

public interface IRespository
{

}
public class GenericRepository<T> : IRespository
{
    public void Add(T item)
    {
        throw new NotImplementedException();
    }
    public void Remove(T item)
    {
        throw new NotImplementedException();
    }
    void Save()
    {
        throw new NotImplementedException();
    }
    IEnumerable<T> GetAll() { return Enumerable.Empty<T>(); }

    T GetById(int id)
    {
        throw new NotImplementedException();
    }
}
