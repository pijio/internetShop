import './VideoReview.css'

const VideoReview = ({setVideoFalse,videoUrl})=>{
    return (
        <div className={'video__review'}>
            <iframe width={'700px'} height={'400px'} src={videoUrl}
                    title="YouTube video player" frameBorder="1"
                    allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"
                    allowFullScreen/>
            <div onClick={()=>setVideoFalse(false)}>
                <img className={'img2'}  src="https://cdn-icons-png.flaticon.com/512/1828/1828665.png" alt=""/>
            </div>

        </div>
    )
}
export default VideoReview