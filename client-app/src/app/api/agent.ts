import axios, { AxiosResponse } from 'axios'
import { Rig } from '../models/rig'
import { RigAsset } from '../models/rigAsset'
import { RigContractor } from '../models/rigContractor'
import { RigOEM } from '../models/rigOEM'
import { RigOperator } from '../models/rigOperator'
import { RigWellOperatorRecord } from '../models/rigWellOperatorRecord'
import { StatusInformation } from '../models/statusInformation'
import { Well } from '../models/well'

const rigAssetAPI = '/rigAssets/'
const rigContractorAPI = '/rigContractors/'
const rigOEMAPI = '/rigOEM/'
const rigOperatorAPI = '/rigOperators/'
const rigAPI = '/rigs/'
const rigWEllOperatorRecordAPI = '/rigWellOperatorRecords/'
const statusInformationAPI = '/statusInformation/'
const wellAPI = '/wells/'

axios.defaults.baseURL = 'http://localhost:5000/api'

//  Adding delay time
const sleep = (delay: number) => {
    return new Promise((resolve) => {
        setTimeout(resolve, delay)
    })
}

axios.interceptors.response.use(async response => {
    try {
        await sleep(1000)
        return response
    } catch (error) {
        console.log(error)
        return await Promise.reject(error)
    }
})

const responseBody = <T>(response: AxiosResponse<T>) => response.data


const request = {
    get: <T>(url: string) => axios.get<T>(url).then(responseBody),
    post: <T>(url: string, body: {}) => axios.post<T>(url, body).then(responseBody),
    put: <T>(url: string, body: {}) => axios.put<T>(url, body).then(responseBody),
    del: <T>(url: string) => axios.delete<T>(url).then(responseBody)
}

//  Rig Asset Request
const RigAssets = {
    list: () => request.get<RigAsset[]>(rigAssetAPI),
    details: (id: string) => request.get<RigAsset>(`${rigAssetAPI}${id}`),
    create: (rigOpertor: RigAsset) => axios.post<void>(`${rigAssetAPI}`, rigOpertor),
    update: (rigOperator: RigAsset) => axios.put<void>(`${rigAssetAPI}${rigOperator.id}`, rigOperator),
    delete: (id: string) => axios.delete<void>(`${rigAssetAPI}${id}`)
}

//  Rig Contractor Request
const RigContractors = {
    list: () => request.get<RigContractor[]>(rigContractorAPI),
    details: (id: string) => request.get<RigContractor>(`${rigContractorAPI}${id}`),
    create: (rigOpertor: RigContractor) => axios.post<void>(`${rigContractorAPI}`, rigOpertor),
    update: (rigOperator: RigContractor) => axios.put<void>(`${rigContractorAPI}${rigOperator.id}`, rigOperator),
    delete: (id: string) => axios.delete<void>(`${rigContractorAPI}${id}`)
}

//  Rig Contractor Request
const RigOEMs = {
    list: () => request.get<RigOEM[]>(rigOEMAPI),
    details: (id: string) => request.get<RigOEM>(`${rigOEMAPI}${id}`),
    create: (rigOpertor: RigOEM) => axios.post<void>(`${rigOEMAPI}`, rigOpertor),
    update: (rigOperator: RigOEM) => axios.put<void>(`${rigOEMAPI}${rigOperator.id}`, rigOperator),
    delete: (id: string) => axios.delete<void>(`${rigOEMAPI}${id}`)
}

//  Rig Operator Request
const RigOperators = {
    list: () => request.get<RigOperator[]>(rigOperatorAPI),
    details: (id: string) => request.get<RigOperator>(`${rigOperatorAPI}${id}`),
    create: (rigOpertor: RigOperator) => axios.post<void>(`${rigOperatorAPI}`, rigOpertor),
    update: (rigOperator: RigOperator) => axios.put<void>(`${rigOperatorAPI}${rigOperator.id}`, rigOperator),
    delete: (id: string) => axios.delete<void>(`${rigOperatorAPI}${id}`)
}

//  Rig Request
const Rigs = {
    list: () => request.get<Rig[]>(rigAPI),
    details: (id: string) => request.get<Rig>(`${rigAPI}${id}`),
    create: (rigOpertor: Rig) => axios.post<void>(`${rigAPI}`, rigOpertor),
    update: (rigOperator: Rig) => axios.put<void>(`${rigAPI}${rigOperator.id}`, rigOperator),
    delete: (id: string) => axios.delete<void>(`${rigAPI}${id}`)
}

//  Rig Well Operator Record Request
const RigWellOperatorRecords = {
    list: () => request.get<RigWellOperatorRecord[]>(rigWEllOperatorRecordAPI),
    details: (id: string) => request.get<RigWellOperatorRecord>(`${rigWEllOperatorRecordAPI}${id}`),
    create: (rigOpertor: RigWellOperatorRecord) => axios.post<void>(`${rigWEllOperatorRecordAPI}`, rigOpertor),
    update: (rigOperator: RigWellOperatorRecord) => axios.put<void>(`${rigWEllOperatorRecordAPI}${rigOperator.id}`, rigOperator),
    delete: (id: string) => axios.delete<void>(`${rigWEllOperatorRecordAPI}${id}`)
}

//  Status Information Request
const StatusInfo = {
    list: () => request.get<StatusInformation[]>(statusInformationAPI),
    details: (id: string) => request.get<StatusInformation>(`${statusInformationAPI}${id}`),
    create: (rigOpertor: StatusInformation) => axios.post<void>(`${statusInformationAPI}`, rigOpertor),
    update: (rigOperator: StatusInformation) => axios.put<void>(`${statusInformationAPI}${rigOperator.id}`, rigOperator),
    delete: (id: string) => axios.delete<void>(`${statusInformationAPI}${id}`)
}

//  Well Request
const Wells = {
    list: () => request.get<Well[]>(wellAPI),
    details: (id: string) => request.get<Well>(`${wellAPI}${id}`),
    create: (rigOpertor: Well) => axios.post<void>(`${wellAPI}`, rigOpertor),
    update: (rigOperator: Well) => axios.put<void>(`${wellAPI}${rigOperator.id}`, rigOperator),
    delete: (id: string) => axios.delete<void>(`${wellAPI}${id}`)
}

const agent = {
    RigAssets,
    RigContractors,
    RigOEMs,
    RigOperators,
    Rigs,
    RigWellOperatorRecords,
    StatusInfo,
    Wells
}

export default agent