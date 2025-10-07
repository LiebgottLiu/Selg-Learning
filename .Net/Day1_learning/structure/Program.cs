using ObjectP;

class Structure {
    static void Main(String[] args) {
        int[] nums = new int[10];
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = i * 142;
        }

        int max = int.MinValue;
        int min = int.MaxValue;
        int sum = 0;
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] < min)
            {
                min = nums[i];
            }
            else if (nums[i] > max)
            {
                max = nums[i];
            }
            sum += nums[i];
        }

        Console.WriteLine(sum);

        double salary = 0;
        // how to use ref
        Jiangjin(ref salary);

        // how to use params
        //求任意长度数组的最大值
        testc("Lip", 99, 99, 99, 55);


        // 引用类
        Person p = new Person();
        p.Daily();
        

    }

    public static void testc(String name, params int[] score){
        int sum = 0;
        for (int i = 0; i < score.Length; i++) { 
            sum += score[i];
        }
        }

    public static double Jiangjin(ref double s) {
        s += 500; 
        return s;
    
    }

    public static double Fakuan(double s) { 
        s -= 500;
        return s;
    }
}