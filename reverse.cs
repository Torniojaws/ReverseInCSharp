using System;
namespace oma {
	class OmaReverse {
		static void Main() {
			int[] nums = {1, 2, 3, 4};
			for(int i=0; i<nums.Length / 2; i++) {
				int tmp = nums[i];
				nums[i] = nums[nums.Length - i - 1];
				nums[nums.Length - i - 1] = tmp;
			}
			foreach(int num in nums) {
				Console.WriteLine(num);
			}
			String teksti = "Tulee takaperin";
			char[] takaperin = teksti.ToCharArray();
			Array.Reverse(takaperin);
			Console.WriteLine(takaperin);
		}
	}
}