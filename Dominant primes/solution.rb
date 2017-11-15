require "prime"
def solve(a,b)
  pos=0
  sum=0
  Prime.each(b) do |i|
      pos+=1
      if(i>a)
       if(Prime.prime?(pos))
         sum+=i
       end
      end
  end
  sum
end
