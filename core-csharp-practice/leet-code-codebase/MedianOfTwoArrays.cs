public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int[] newarr=new int[nums1.Length+nums2.Length];
        int idx=0;

        for(int i=0;i<nums1.Length;i++){
            newarr[idx++]=nums1[i];
        }
        for(int i=0;i<nums2.Length;i++){
            newarr[idx++]=nums2[i];
            }
        Array.Sort(newarr);
        int n=newarr.Length;
        if(n%2==0){
            return (newarr[n/2]+newarr[n/2-1])/2.0;
        }else{
            return newarr[n/2];

        } 
        return 0;
    

        
    }
}    

        