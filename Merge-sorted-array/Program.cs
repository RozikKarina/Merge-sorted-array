public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int i = m - 1;      // Останній елемент у nums1, який треба обробити
        int j = n - 1;      // Останній елемент у nums2
        int k = m + n - 1;  // Остання позиція в nums1

        // Заповнюємо nums1 з кінця до початку
        while (i >= 0 && j >= 0)
        {
            if (nums1[i] > nums2[j])
            {
                nums1[k] = nums1[i];
                i--;
            }
            else
            {
                nums1[k] = nums2[j];
                j--;
            }
            k--;
        }

        // Якщо залишилися елементи у nums2, копіюємо їх у nums1
        while (j >= 0)
        {
            nums1[k] = nums2[j];
            j--;
            k--;
        }
    }
}
