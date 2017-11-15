def unique_in_order(iterable)
  if iterable.instance_of? String
  iterable = iterable.scan /\w/
  end
  iterable.chunk{|n| n}.map(&:first)
end
