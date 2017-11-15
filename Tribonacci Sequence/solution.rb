def tribonacci(signature,n)
  if n==0
    []
  elsif n==1
    []<<signature[0]
  elsif n==2
    signature.pop
    signature
  else
    for t in 3..n-1 do
    signature << signature[t-1]+signature[t-2]+signature[t-3]
    end
    signature
  end
end
