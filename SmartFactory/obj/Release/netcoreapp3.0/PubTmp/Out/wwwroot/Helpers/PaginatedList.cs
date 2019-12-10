using System;
using System.Collections.Generic;
using System.Linq;

namespace SmartFactory.Helpers
{
    public class PaginatedList<T> : List<T>
    {
        // 속성 선언
        public PaginatedList(IQueryable<T> source, int pageIndex, int pageSize)
        {
            PageIndex = pageIndex;
            PageSize = pageSize;
            TotalCount = source.Count(); // 데이터원본에 들어있는 레코드의 수
            TotalPages = (int) Math.Ceiling(TotalCount/(double) PageSize); // 총 페이지 수

            // 현재 페이지 인덱스에 맞는 레코드만 담자...
            AddRange(source.Skip(PageIndex*PageSize).Take(PageSize));
        }

        public int PageIndex { get; set; } // 페이지 인덱스 : 0번째 페이지~n-1번째 페이지
        public int PageSize { get; set; } // 한 페이지에 보여줄 레코드 수 : 10개씩 설정
        public int TotalCount { get; set; } // 총 몇개의 레코드가 테이블에 담겨있는지 저장
        public int TotalPages { get; set; } // 페이지 수

        // 생성자

        // 속성 2개 노출 : 이전/다음 페이지가 있는지 
        public bool HasPreviousPage
        {
            get { return (PageIndex > 0); }
        }

        public bool HasNextPage
        {
            get { return (PageIndex + 1 < TotalPages); }
        }
    }
}