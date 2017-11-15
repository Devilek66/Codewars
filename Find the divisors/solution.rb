def divisors(n)
  ara = []
  for i in 2..((n/2)+1)
    if n % i == 0
    ara << i
    end
  end
  if ara.empty?
    "#{n} is prime"
  else
    ara
  end
end
