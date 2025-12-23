public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        int[] arr =new int[2]; // create array
        for(int i=0;i<nums.Length;i++){ //loop 
            for(int j=i+1;j<nums.Length;j++){
                if(nums[i]+nums[j]==target){ //compare with target
                    arr[0]=i;
                    arr[1]=j;
                }
            }
        }
        return arr; //output
        
    }
}