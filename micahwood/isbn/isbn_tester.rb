module Isbn
  class IsbnTester
    ISBN_REGEX = /^\d{9}[\d|x]$/i
    def self.test(isbn)
      tr_isbn = isbn.tr('-', '')
      if tr_isbn =~ ISBN_REGEX && self.perform_test(tr_isbn)
        puts "#{isbn} is valid"
      else
        puts "#{isbn} is not valid"
      end
    end

    private
    def self.perform_test(isbn)
      total = 0
      isbn.each_char.with_index do | value, index |
        value = 10 if value.casecmp('x') == 0
        total += (10 - index) * value.to_i
      end
      total % 11 == 0
    end
  end
end