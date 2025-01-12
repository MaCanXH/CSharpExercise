using System;

class Q15
{
    public static void ans15()
    {
        //input a number for checking
        int num = 8;

        //record the values of bits in the desired position
        int bit3 = (num >> 3) & 1; //3rd bit (from 0)
        int bit4 = (num >> 4) & 1; //4th bit (from 0)
        int bit5 = (num >> 5) & 1; //5th bit (from 0)

        int bit24 = (num >> 24) & 1; //24th bit (from 0)
        int bit25 = (num >> 25) & 1; //25th bit (from 0)
        int bit26 = (num >> 26) & 1; //26th bit (from 0)


        //process the postion swap
        //for & with 1111... it is keeping the comparing number
        //therefore moving 1 to desired postion and flip it is for the value checking in repective postion only
        //e.g. ~(1 << 24)
        //(~(1 << 24)) | (bit3 << 24) this part is to check the value in postion 24
        num = num & (~(1 << 24)) | (bit3 << 24);
        num = num & (~(1 << 25)) | (bit4 << 25);
        num = num & (~(1 << 26)) | (bit5 << 26);

        num = num & (~(1 << 3)) | (bit24 << 3);
        num = num & (~(1 << 4)) | (bit25 << 4);
        num = num & (~(1 << 5)) | (bit26 << 5);

        Console.WriteLine(num);
    }
}

