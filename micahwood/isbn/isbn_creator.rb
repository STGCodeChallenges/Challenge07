module Isbn
  class IsbnCreator
    MAX_ISBN_SEED = 45
    def self.create
      total = 11 * rand(MAX_ISBN_SEED)
      isbn = []
      (0..9).each_with_index do | i |
          if i < 9
            num = rand(9)
            diff = (10 - i) * num
            if diff < total
              total -= diff
            else
              num = 0
            end
          else
            #hacky way of handling event where random numbers chosen were
            #too small to create a valid isbn
            return self.create if total > 10
            num = total == 10 ? 'X' : total
          end
          isbn[i] = num
      end
      isbn.join
    end
  end
end
