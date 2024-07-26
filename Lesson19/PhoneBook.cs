class PhoneBook : Phone
{
    Contact[] phoneList = new Contact[0];

    public override void InsertPhone(string _name, string _phone)
    {
        bool check = false;

        for (int i = 0; i < phoneList.Length; i++)
        {
            if (phoneList[i].name == _name)
            {
                check = true;
                phoneList[i].phoneNumber = $"{phoneList[i].phoneNumber} : {_phone}";
            }
        }

        if (!check)
        {
            Array.Resize(ref phoneList, phoneList.Length + 1);
            phoneList[phoneList.Length - 1] = new Contact(_name, _phone);
        }
    }

    public override void RemovePhone(string _name)
    {
        int count1 = 0;
        for (int i = 0; i < phoneList.Length; i++)
        {
            if (phoneList[i].name == _name)
            {
                if (i != phoneList.Length - 1)
                {
                    int count2 = 0;
                    Contact[] tempList = new Contact[0];
                    for (int j = i + 1; j < phoneList.Length; j++)
                    {
                        Array.Resize(ref tempList, tempList.Length + 1);
                        tempList[count2] = phoneList[j];
                        count2++;                       
                    }
                    count2 = 0;
                    for (int j = i; j < phoneList.Length - 1; j++)
                    {
                        phoneList[j] = tempList[count2];
                        count2++;
                    }
                    Array.Resize(ref phoneList, phoneList.Length - 1);
                }
                else
                {
                    Array.Resize(ref phoneList, phoneList.Length - 1);
                }
                break;
            }
            else
            {
                count1++;
            }
        }
        if (count1 == phoneList.Length)
        {
            Console.WriteLine("Not found");
        }
    }

    public override void UpdatePhone(string _name, string _newPhone)
    {
        int count = 0;
        for (int i = 0; i < phoneList.Length; i++)
        {
            if (phoneList[i].name == _name)
            {
                if (phoneList[i].name == _name)
                {
                    phoneList[i].phoneNumber = _newPhone;
                }
                break;
            }
            else
            {
                count++;
            }
        }
        if (count == phoneList.Length)
        {
            Console.WriteLine("Not found");
        }
    }

    public override void SearchPhone(string _name)
    {
        int count = 0;
        for (int i = 0; i < phoneList.Length; i++)
        {

            if (phoneList[i].name == _name)
            {
                Console.WriteLine($"{phoneList[i].name}: {phoneList[i].phoneNumber}");
                break;
            }
            else
            {
                count++;
            }
        }
        if (count == phoneList.Length)
        {
            Console.WriteLine("Not found");
        }
    }

    public override void Sort()
    {
        string[] nameList = new string[phoneList.Length];
        Contact[] tempList = new Contact[phoneList.Length];

        for (int i = 0; i < phoneList.Length; i++)
        {
            nameList[i] = phoneList[i].name;
            tempList[i] = phoneList[i];
        }
        Array.Sort(nameList);

        for (int i = 0; i < phoneList.Length; i++)
        {
            phoneList[i].name = nameList[i];
            for (int j = 0; j < tempList.Length; j++)
            {
                if (phoneList[i].name == tempList[j].name)
                {
                    phoneList[i].phoneNumber = tempList[j].phoneNumber;
                }
            }
        }
    }

    public void PrintPhoneList()
    {
        for (int i = 0; i < phoneList.Length; i++)
        {
            Console.WriteLine($"{phoneList[i].name}: {phoneList[i].phoneNumber}");
        }
        Console.WriteLine("==============");
    }
}

class Contact
{
    public string name;
    public string phoneNumber;

    public Contact(string _name, string _phoneNumber)
    {
        name = _name;
        phoneNumber = _phoneNumber;
    }
}